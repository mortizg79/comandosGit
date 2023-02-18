using ComandosGitWebAPI.Models;

namespace ComandosGitWebAPI.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAllAsync();
        Task<Client> GetAsync(string id);
        void DeleteAsync(string id);
    }
}
