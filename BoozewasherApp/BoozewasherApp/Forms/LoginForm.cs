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
        public LoginForm(ILoginRepository loginRepository)
        {
            InitializeComponent();
            LoginRepository = loginRepository;
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
            }
            else
            {
                MessageBox.Show(validate.ResponseMessage);
            }
        }
    }
}
