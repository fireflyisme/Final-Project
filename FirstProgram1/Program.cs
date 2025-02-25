using Inventory1.Data;
using Unity.Lifetime;
using Unity;
using InfastructureLayer.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;
using InfastructureLayer.Data.Repositories;
using AutoMapper;
using ServiceLayer;
using Inventory1.Views.IViews;
using Inventory1.Presenters;

namespace Inventory1
{
    internal static class Program
    {
        public static IMapper Mapper { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC = new UnityContainer();

            UnityC.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingService>();
            });
            Mapper = mapperConfig.CreateMapper();

            UnityC.RegisterInstance(Mapper);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var unitOfWork = UnityC.Resolve<IUnitOfWork>();
            var appUserForm = new AppUserForm();
            new AppUserFormPresenter(unitOfWork, appUserForm);
            Application.Run(appUserForm);
        }
    }
}