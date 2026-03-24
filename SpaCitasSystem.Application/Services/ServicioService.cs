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

        await base.AddAsync(dto);
    }
}