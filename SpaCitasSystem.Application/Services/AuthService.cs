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
                u.Username.ToLower() == username.ToLower() &&
                u.Activo == true);

            if (usuario == null)
                return false;

            //validar password hash
            bool esValido = BCrypt.Net.BCrypt.Verify(password, usuario.PasswordHash);

            return esValido;
        }
    }
}