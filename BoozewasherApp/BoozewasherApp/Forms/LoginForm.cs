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
        public ILoginRepository LoginRepository { get; private set; }
        public IServiceRepository ServiceRepository { get; private set; }
        public IVehicleRepository VehicleRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public LoginForm(ILoginRepository loginRepository, 
                         IServiceRepository serviceRepository,
                         IItemRepository itemRepository,
                         IVehicleRepository vehicleRepository,
                         ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            LoginRepository = loginRepository;
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var credentials = new LoginDto
            {
                Email = txtboxEmail.Text,
                Password = txtboxPassword.Text,
                RememberMe = false
            };
            var validate = LoginRepository.AuthenticateLogin(credentials);

            if (validate.IsAuthenticated)
            {
                MessageBox.Show(validate.ResponseMessage);
                var mainForm = new MainForm(ServiceRepository, ItemRepository, VehicleRepository, TransactionRepository);
                mainForm.LoginForm = this;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validate.ResponseMessage);
            }
        }

        public void ResetFields()
        {
            txtboxEmail.Text = string.Empty;
            txtboxPassword.Text = string.Empty;
        }

    }
}
