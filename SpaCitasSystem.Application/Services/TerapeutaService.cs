using AutoMapper;
using SpaCitasSystem.Application.Common;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Infrastructure.Interfaces;

public class TerapeutaService
    : GenericService<Terapeuta, TerapeutaDto>, ITerapeutaService
{
    public TerapeutaService(
        IGenericRepository<Terapeuta> repo,
        IMapper mapper)
        : base(repo, mapper)
    {
    }

    public override async Task AddAsync(TerapeutaDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Nombre))
            throw new Exception("El nombre es obligatorio");

        if (string.IsNullOrWhiteSpace(dto.Especialidad))
            throw new Exception("La especialidad es obligatoria");

        await base.AddAsync(dto);
    }
}