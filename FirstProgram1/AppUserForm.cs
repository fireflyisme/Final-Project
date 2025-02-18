using DomainLayer.ViewModels;
using FirstProgram1.Data;
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

namespace FirstProgram1
{
    public partial class AppUserForm : Form
    {
        private IUnitOfWork _unitOfWork;

        public AppUserForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;

            getAllPrograms();
            getAllAppUsers();
        }

        private void getAllAppUsers()
        {
            var appUsers = _unitOfWork.userRepository.GetAll(includeProperties: "Program");
            var appUsersVM = Program.Mapper.Map<IEnumerable<AppUserViewModel>>(appUsers);
            dataGridView1.DataSource = appUsersVM.OrderBy(c => c.Name).ToList();
        }

        private void getAllPrograms()
        {
            comboBoxProgram.DataSource = _unitOfWork.programRepository.GetAll();
            comboBoxProgram.ValueMember = "ProgramId";
            comboBoxProgram.DisplayMember = "ProgramName";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var selectedProgram = comboBoxProgram.SelectedValue;
            var appUser = new AppUser()
            {
                Name = textBoxName.Text.Trim().ToUpper(),
                UserName = textBoxUserName.Text.Trim(),
                ProgramId = (int?)selectedProgram
            };

            _unitOfWork.userRepository.Add(appUser);
            _unitOfWork.Save();

            MessageBox.Show("App User saves successfully.");
            getAllAppUsers();
        }
    }
}
