using DomainLayer.Models;
using Inventory1.Data;
using Inventory1.Data.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;

namespace InfastructureLayer.Repositories
{
    //public class AllowanceRepository : BaseRepository, IAllowanceRepository
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private AppDbContext _db;
        public AppUserRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AppUser obj)
        {
            _db.AppUsers.Update(obj);
        }
    }
}
