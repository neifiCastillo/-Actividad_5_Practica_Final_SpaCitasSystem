using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Infrastructure.Interfaces;

namespace SpaCitasSystem.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepo;

        public UsuarioService(IGenericRepository<Usuario> usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public async Task CrearUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepo.AddAsync(usuario);
        }
    }
}