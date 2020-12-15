
using BoozewasherDomain.Entities;
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

namespace BoozewasherApp.Forms.ServiceForms
{
    public partial class AddServiceForm : Form
    {
        private IServiceRepository ServiceRepository { get; set; }
        public AddServiceForm(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
        }
        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }
        private void btnAdd_Click(object sender, EventArgs e) => AddService();

        #region Private Methods

        private void AddService()
        {
            var service = new Service()
            {
                Type = txtboxType.Text,
                Description = txtboxDescription.Text,
                Expense = decimal.Parse(txtboxExpense.Text)
            };

            ServiceRepository.AddService(service);

            LoadDgvService();
        }

        private void LoadDgvService()
        {
            dgvService.DataSource = ServiceRepository.GetAllServices();
        }

        #endregion
    }
}
