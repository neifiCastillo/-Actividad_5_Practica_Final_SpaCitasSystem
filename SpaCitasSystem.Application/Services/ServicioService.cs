using AutoMapper;
using SpaCitasSystem.Application.Common;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Infrastructure.Interfaces;

public class ServicioService
    : GenericService<Servicio, ServicioDto>, IServicioService
{
    public ServicioService(
        IGenericRepository<Servicio> repo,
        IMapper mapper)
        : base(repo, mapper)
    {
    }

    public override async Task AddAsync(ServicioDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Nombre))
            throw new Exception("El nombre es obligatorio");

        if (dto.DuracionMinutos <= 0)
            throw new Exception("La duración debe ser mayor a 0");

        if (dto.Precio <= 0)
            throw new Exception("El precio debe ser mayor a 0");

        var servicios = await _repo.GetAllAsync();

        var existe = servicios.Any(s =>
      s.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim() ||
      s.DuracionMinutos == dto.DuracionMinutos);

        if (existe)
            throw new Exception("Ya existe un servicio con ese nombre");

        await base.AddAsync(dto);
    }
    public override async Task UpdateAsync(ServicioDto dto)
    {
        var servicios = await _repo.GetAllAsync();

        var existe = servicios.Any(s =>
            s.Id != dto.Id &&
            s.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim()
        );

        if (existe)
            throw new Exception("Ya existe otro servicio con ese nombre");

        await base.UpdateAsync(dto);
    }
}