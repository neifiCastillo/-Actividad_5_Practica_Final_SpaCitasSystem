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

        var terapeutas = await _repo.GetAllAsync();

        var existe = terapeutas.Any(t =>
            t.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim() &&
            t.Especialidad.ToLower().Trim() == dto.Especialidad.ToLower().Trim()
        );

        if (existe)
            throw new Exception("Ya existe un terapeuta con ese nombre y especialidad");

        await base.AddAsync(dto);
    }
    public override async Task UpdateAsync(TerapeutaDto dto)
    {
        var terapeutas = await _repo.GetAllAsync();

        var existe = terapeutas.Any(t =>
            t.Id != dto.Id &&
            t.Nombre.ToLower().Trim() == dto.Nombre.ToLower().Trim() &&
            t.Especialidad.ToLower().Trim() == dto.Especialidad.ToLower().Trim()
        );

        if (existe)
            throw new Exception("Ya existe otro terapeuta con ese nombre y especialidad");

        await base.UpdateAsync(dto);
    }
}