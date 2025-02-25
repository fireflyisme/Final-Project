using DomainLayer.ViewModels;
using Inventory1.Data;
using Inventory1.Views.IViews;
using InfastructureLayer.Data.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;
using InfastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory1.Presenters
{
    public class AppUserFormPresenter
    {
        private IUnitOfWork unitOfWork;
        private IAppUserForm appUserForm;
        private BindingSource programBindingSource;
        private BindingSource appUserBindingSource;
        private IEnumerable<DomainLayer.Models.Program> programs;
        private IEnumerable<AppUserViewModel> appUserList;

        public AppUserFormPresenter(IUnitOfWork unitOfWork, IAppUserForm appUserForm)
        {
            this.unitOfWork = unitOfWork;
            this.appUserForm = appUserForm;
            programBindingSource = new BindingSource();
            appUserBindingSource = new BindingSource();

            this.appUserForm.AddNew += Add;

            getAllPrograms();
            getAllAppUsers();

            this.appUserForm.getAllPrograms(programBindingSource);
            this.appUserForm.getAllAppUsers(appUserBindingSource);
        }

        private void getAllAppUsers()
        {
            var appUsers = unitOfWork.userRepository.GetAll(includeProperties: "Program");
            appUserList = Program.Mapper.Map<IEnumerable<AppUserViewModel>>(appUsers);
            appUserBindingSource.DataSource = appUserList.OrderBy(c => c.Name);
        }

        private void getAllPrograms()
        {
            programs = unitOfWork.programRepository.GetAll();
            programBindingSource.DataSource = programs;
        }

        private void Add(object? sender, EventArgs e)
        {
            var appUser = new AppUser()
            {
                Name = appUserForm.AppUserName,
                UserName = appUserForm.UserName,
                ProgramId = appUserForm.ProgramId,
            };

            unitOfWork.userRepository.Add(appUser);
            unitOfWork.Save();
            appUserForm.IsSuccessful = true;
            appUserForm.Message = "App User saves successfully.";

            getAllAppUsers();
        }
    }
}
