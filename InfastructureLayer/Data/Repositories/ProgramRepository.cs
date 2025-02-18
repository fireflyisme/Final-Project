using DomainLayer.Models;
using FirstProgram1.Data;
using FirstProgram1.Data.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;

namespace InfastructureLayer.Repositories
{
    //public class AllowanceRepository : BaseRepository, IAllowanceRepository
    public class ProgramRepository : Repository<Program>, IProgramRepository
    {
        private AppDbContext _db;
        public ProgramRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Program obj)
        {
            _db.Programs.Update(obj);
        }
    }
}
