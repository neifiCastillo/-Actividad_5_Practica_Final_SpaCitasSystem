using SpaCitasSystem.Domain.Entities;

namespace SpaCitasSystem.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task CrearUsuarioAsync(Usuario usuario);
    }
}