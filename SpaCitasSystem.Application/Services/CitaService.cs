using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Domain.Entities;

public class CitaService : ICitaService
{
    private readonly SpaDbContext _context;
    private readonly IMapper _mapper;

    public CitaService(SpaDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CitaDto>> GetAllAsync()
    {
        var citas = await _context.Citas
            .Include(c => c.Paciente)
            .Include(c => c.Servicio)
            .Include(c => c.Terapeuta)
            .ToListAsync();

        var result = citas.Select(c => new CitaDto
        {
            Id = c.Id,
            PacienteId = c.PacienteId,
            PacienteNombre = c.Paciente.Nombre,

            ServicioId = c.ServicioId,
            ServicioNombre = c.Servicio.Nombre,

            TerapeutaId = c.TerapeutaId,
            TerapeutaNombre = c.Terapeuta.Nombre,

            Fecha = c.Fecha,
            Hora = c.Hora,

            //Calculado
            DuracionMinutos = c.Servicio.DuracionMinutos,
            DiasRestantes = (c.Fecha - DateTime.Now.Date).Days,
            Estado = CalcularEstado(c)
        });

        return result;
    }

    public async Task AddAsync(CitaDto dto)
    {
        var servicio = await _context.Servicios.FindAsync(dto.ServicioId);

        if (servicio == null)
            throw new Exception("Servicio no encontrado");

        await ValidarConflictoCita(
        dto.TerapeutaId,
        dto.Fecha,
        dto.Hora,
        servicio.DuracionMinutos
    );

        var cita = new Cita
        {
            PacienteId = dto.PacienteId,
            ServicioId = dto.ServicioId,
            TerapeutaId = dto.TerapeutaId,
            Fecha = dto.Fecha,
            Hora = dto.Hora
        };

        await _context.Citas.AddAsync(cita);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CitaDto dto)
    {
        var cita = await _context.Citas.FindAsync(dto.Id);

        if (cita == null)
            throw new Exception("La cita no existe");

        var servicio = await _context.Servicios.FindAsync(dto.ServicioId);
        if (servicio == null)
            throw new Exception("Servicio no encontrado");

        var paciente = await _context.Pacientes.FindAsync(dto.PacienteId);
        if (paciente == null)
            throw new Exception("Paciente no encontrado");

        var terapeuta = await _context.Terapeutas.FindAsync(dto.TerapeutaId);
        if (terapeuta == null)
            throw new Exception("Terapeuta no encontrado");

        await ValidarConflictoCita(
      dto.TerapeutaId,
      dto.Fecha,
      dto.Hora,
      servicio.DuracionMinutos,
      dto.Id 
         );

        cita.PacienteId = dto.PacienteId;
        cita.ServicioId = dto.ServicioId;
        cita.TerapeutaId = dto.TerapeutaId;
        cita.Fecha = dto.Fecha;
        cita.Hora = dto.Hora;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var cita = await _context.Citas.FindAsync(id);

        if (cita != null)
        {
            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();
        }
    }

    private string CalcularEstado(Cita c)
    {
        var fechaHora = c.Fecha + c.Hora;
        var fin = fechaHora.AddMinutes(c.Servicio.DuracionMinutos);

        if (DateTime.Now < fechaHora)
            return "Vigente";

        if (DateTime.Now >= fechaHora && DateTime.Now <= fin)
            return "En proceso";

        return "Finalizado";
    }

    private async Task ValidarConflictoCita(
    int terapeutaId,
    DateTime fecha,
    TimeSpan hora,
    int duracionMinutos,
    int? citaId = null)
    {
        var fechaHoraNueva = fecha + hora;
        var finNueva = fechaHoraNueva.AddMinutes(duracionMinutos);

        var citas = await _context.Citas
            .Include(c => c.Servicio)
            .Where(c => c.TerapeutaId == terapeutaId)
            .ToListAsync(); 

        var conflicto = citas.Any(c =>
        {
            var inicioExistente = c.Fecha + c.Hora;
            var finExistente = inicioExistente.AddMinutes(c.Servicio.DuracionMinutos);

            return (!citaId.HasValue || c.Id != citaId.Value) &&
                   inicioExistente < finNueva &&
                   finExistente > fechaHoraNueva;
        });

        if (conflicto)
            throw new Exception("El terapeuta ya tiene una cita en ese horario");
    }
}