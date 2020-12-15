
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
    public partial class UpdateServiceForm : Form
    {
        private IServiceRepository ServiceRepository { get; set; }
        private int SelectedServiceId { get; set; }
        public UpdateServiceForm(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
        }
        private void UpdateServiceForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var service = new Service()
            {
                Id = SelectedServiceId,
                Type = txtboxType.Text,
                Description = txtboxDescription.Text,
                Expense = decimal.Parse(txtboxExpense.Text)
            };

            ServiceRepository.UpdateService(service);

            LoadDgvService();
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvService.SelectedRows[0].Cells[0].Value;

            txtboxType.Text = dgvService.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvService.SelectedRows[0].Cells[2].Value.ToString();
            txtboxExpense.Text = dgvService.SelectedRows[0].Cells[3].Value.ToString();
        }
        #region Private Methods
        private void LoadDgvService()
        {
            dgvService.DataSource = ServiceRepository.GetAllServices();
        }
        #endregion
    }
}
