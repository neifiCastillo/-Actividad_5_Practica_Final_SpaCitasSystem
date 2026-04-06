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
            var usuarios = await _usuarioRepo.GetAllAsync();

            var existe = usuarios.Any(u => u.Username.ToLower() == usuario.Username.ToLower());

            if (existe)
                throw new Exception("El usuario ya existe");

            usuario.PasswordHash = HashPassword(usuario.PasswordHash);

            await _usuarioRepo.AddAsync(usuario);
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}