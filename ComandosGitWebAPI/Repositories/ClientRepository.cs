using ComandosGitWebAPI.Models;
using ComandosGitWebAPI.Repositories.Interfaces;

namespace ComandosGitWebAPI.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<List<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
