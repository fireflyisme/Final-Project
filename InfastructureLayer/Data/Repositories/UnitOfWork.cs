using Inventory1.Data;
using InfastructureLayer.Data.Repositories.IRepositories;
using InfastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureLayer.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext dbContext;
        public IAppUserRepository userRepository { get; private set; }
        public IProgramRepository programRepository { get; private set; }
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            userRepository ??= new AppUserRepository(dbContext);
            programRepository ??= new ProgramRepository(dbContext);
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
