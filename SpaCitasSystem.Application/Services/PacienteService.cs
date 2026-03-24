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

            await base.AddAsync(dto);
        }
    }
}