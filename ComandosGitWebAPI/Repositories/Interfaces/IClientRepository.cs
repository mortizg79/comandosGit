using ComandosGitWebAPI.Models;

namespace ComandosGitWebAPI.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAllAsync();
    }
}
