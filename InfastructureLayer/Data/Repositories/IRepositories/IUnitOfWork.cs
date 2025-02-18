namespace InfastructureLayer.Data.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IProgramRepository programRepository { get; }
        IAppUserRepository userRepository { get; }

        void Save();
    }
}