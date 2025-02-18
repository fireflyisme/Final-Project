using DomainLayer.Models;

namespace InfastructureLayer.Data.Repositories.IRepositories
{
    public interface IProgramRepository : IRepository<Program>
    {
        void Update(Program obj);
    }
}