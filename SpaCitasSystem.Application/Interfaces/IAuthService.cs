namespace SpaCitasSystem.Application.Interfaces
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(string username, string password);
    }
}