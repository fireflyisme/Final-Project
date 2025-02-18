using DomainLayer.Models;
using FirstProgram1.Data;

namespace InfastructureLayer.Data.Repositories.IRepositories
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        void Update(AppUser obj);
    }
}