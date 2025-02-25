using DomainLayer.ViewModels;
using Inventory1.Data;
using Inventory1.Views.IViews;
using InfastructureLayer.Data.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory1
{
    public partial class AppUserForm : Form, IAppUserForm
    {
        private string _message;
        private bool _isSuccessful = false;
        //private IUnitOfWork _unitOfWork;

        public AppUserForm(/*IUnitOfWork unitOfWork*/)
        {
            InitializeComponent();
            //_unitOfWork = unitOfWork;

            //getAllPrograms();
            //getAllAppUsers();
            buttonSaveUser.Click += delegate
            {
                AddNew?.Invoke(this, EventArgs.Empty);
                if (_isSuccessful)
                {
                    MessageBox.Show(_message);
                }
            };
        }

        public event EventHandler AddNew;

        public string Message { set => _message = value; }
        public bool IsSuccessful { set => _isSuccessful = value; }
        public string Id { get; set; }
        public string AppUserName { get => textBoxName.Text.Trim().ToUpper(); set => textBoxName.Text = value; }
        public string UserName { get => textBoxUserName.Text.Trim(); set => textBoxUserName.Text = value; }
        public int ProgramId { get => (int)comboBoxProgram.SelectedValue; set => comboBoxProgram.SelectedValue = value; }

        public void getAllPrograms(BindingSource bindingSource)
        {
            comboBoxProgram.DataSource = bindingSource;
            comboBoxProgram.ValueMember = "ProgramId";
            comboBoxProgram.DisplayMember = "ProgramName";
        }

        public void getAllAppUsers(BindingSource bindingSource)
        {
            dataGridViewUsers.DataSource = bindingSource;
        }


        //private void getAllAppUsers()
        //{
        //    var appUsers = _unitOfWork.userRepository.GetAll(includeProperties: "Program");
        //    var appUsersVM = Program.Mapper.Map<IEnumerable<AppUserViewModel>>(appUsers);
        //    dataGridView1.DataSource = appUsersVM.OrderBy(c => c.Name).ToList();
        //}

        //private void getAllPrograms()
        //{
        //    comboBoxProgram.DataSource = _unitOfWork.programRepository.GetAll();
        //    comboBoxProgram.ValueMember = "ProgramId";
        //    comboBoxProgram.DisplayMember = "ProgramName";
        //}

        //private void materialButton1_Click(object sender, EventArgs e)
        //{
        //    var selectedProgram = comboBoxProgram.SelectedValue;
        //    var appUser = new AppUser()
        //    {
        //        Name = textBoxName.Text.Trim().ToUpper(),
        //        UserName = textBoxUserName.Text.Trim(),
        //        ProgramId = (int?)selectedProgram
        //    };

        //    _unitOfWork.userRepository.Add(appUser);
        //    _unitOfWork.Save();

        //    MessageBox.Show("App User saves successfully.");
        //    getAllAppUsers();
        //}
    }
}
