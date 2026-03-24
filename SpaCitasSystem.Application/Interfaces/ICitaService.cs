using SpaCitasSystem.Domain.DTOs;

namespace SpaCitasSystem.Application.Interfaces
{
    public interface ICitaService
    {
        Task<IEnumerable<CitaDto>> GetAllAsync();
        Task AddAsync(CitaDto dto);
        Task UpdateAsync(CitaDto dto);
        Task DeleteAsync(int id);
    }
}
