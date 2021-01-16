using BoozewasherDomain.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.ServiceForms
{
    public partial class AddServiceUserControl : UserControl
    {
        public MainForm mainForm { get; set; }
        public AddServiceUserControl()
        {
            InitializeComponent();
        }

        private void AddServiceUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddService();
            LoadDgvServices();
        }

        #region Private/public Methods
        private void AddService()
        {
            var service = new Service()
            {
                Type = txtboxType.Text,
                Description = txtboxDescription.Text,
                Expense = decimal.Parse(txtboxExpense.Text)
            };
            ServiceValidator validator = new ServiceValidator();
            ValidationResult result = validator.Validate(service);

            if (result.IsValid)
            {
                mainForm.ServiceRepository.AddService(service);
            }
            else
            {
                MessageBox.Show(result.ToString());
            }
            
        }
        public void ResetFields()
        {
            txtboxType.Text = string.Empty;
            txtboxDescription.Text = string.Empty;
            txtboxExpense.Text = string.Empty;
        }
        public void LoadDgvServices()
        {
            dgvServices.DataSource = mainForm.ServiceRepository.GetAllServices();
        }

        #endregion
    }
}
