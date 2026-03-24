using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Infrastructure.Interfaces;

namespace SpaCitasSystem.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepo;

        public AuthService(IGenericRepository<Usuario> usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var usuarios = await _usuarioRepo.GetAllAsync();

            var usuario = usuarios.FirstOrDefault(u =>
                u.Username == username &&
                u.PasswordHash == password &&
                u.Activo == true);

            return usuario != null;
        }
    }
}