using AutoMapper;
using SpaCitasSystem.Application.Common;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Infrastructure.Interfaces;

namespace SpaCitasSystem.Application.Services
{
    public class PacienteService
        : GenericService<Paciente, PacienteDto>, IPacienteService
    {
        public PacienteService(
            IGenericRepository<Paciente> repo,
            IMapper mapper)
            : base(repo, mapper)
        {
        }

        public override async Task AddAsync(PacienteDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new Exception("El nombre es obligatorio");

            var pacientes = await _repo.GetAllAsync();
            var existe = pacientes.Any(p =>
                p.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim() ||
                p.Telefono == dto.Telefono ||
                p.Email.ToLower().Trim() == dto.Email.ToLower().Trim()
            );

            if (existe)
                throw new Exception("Ya existe un paciente con ese nombre");

            await base.AddAsync(dto);
        }

        public override async Task UpdateAsync(PacienteDto dto)
        {
            var pacientes = await _repo.GetAllAsync();

            var existe = pacientes.Any(p =>
                p.Id != dto.Id &&
                p.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim()
            );

            if (existe)
                throw new Exception("Ya existe otro paciente con ese nombre");

            await base.UpdateAsync(dto);
        }
    }
}