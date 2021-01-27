using BoozewasherDomain.Dtos;
using BoozewasherDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms
{
    public partial class LoginForm : Form
    {
        public IBranchRepository BranchRepository { get; private set; }
        public ILoginRepository LoginRepository { get; private set; }
        public IServiceRepository ServiceRepository { get; private set; }
        public IVehicleRepository VehicleRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public LoginForm(IBranchRepository branchRepository,
                         ILoginRepository loginRepository, 
                         IServiceRepository serviceRepository,
                         IItemRepository itemRepository,
                         IVehicleRepository vehicleRepository,
                         ITransactionRepository transactionRepository,
                         IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            BranchRepository = branchRepository;
            LoginRepository = loginRepository;
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
            EmployeeRepository = employeeRepository;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int? selectedBranchId = null;
            if (comboBranch.SelectedItem != null)
            {
                selectedBranchId = GetBranchIdFromComboBox();
            }

            var credentials = new LoginDto
            {
                Email = txtboxEmail.Text,
                Password = txtboxPassword.Text,
                RememberMe = false
            };
            var validate = LoginRepository.AuthenticateLogin(credentials);

            var UserInformation = new UserInformationDto()
            {
                FirstName = validate.FirstName,
                LastName = validate.LastName,
                BranchId = selectedBranchId.Value
            };

            if (validate.IsAuthenticated)
            {
                MessageBox.Show(validate.ResponseMessage);
                var mainForm = new MainForm(UserInformation, ServiceRepository, ItemRepository, VehicleRepository, TransactionRepository, EmployeeRepository);
                mainForm.LoginForm = this;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validate.ResponseMessage);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadBranchesToCombobox();
        }
        #region Private/public methods
        private int GetBranchIdFromComboBox()
        {
            var selectedItem = comboBranch.SelectedItem.ToString();
            var branchId = selectedItem.Split('-')[0].Trim();
            return int.Parse(branchId);
        }
        private void LoadBranchesToCombobox()
        {
            var branches = BranchRepository.GetAllBranches();

            foreach (var branch in branches)
            {
                comboBranch.Items.Add($"{branch.Id} - {branch.Name}");
            }
        }
        public void ResetFields()
        {
            txtboxEmail.Text = string.Empty;
            txtboxPassword.Text = string.Empty;
        }

        #endregion
    }
}
