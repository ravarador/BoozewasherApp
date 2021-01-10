using BoozewasherDomain.Entities;
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
    public partial class UpdateServiceUserControl : UserControl
    {
        private int SelectedServiceId { get; set; }
        public MainForm mainForm;
        public UpdateServiceUserControl()
        {
            InitializeComponent();
        }

        private void UpdateServiceUserControl_Load(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateService();
            LoadDgvServices();
        }
        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvServices.SelectedRows[0].Cells[0].Value;

            txtboxType.Text = dgvServices.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvServices.SelectedRows[0].Cells[2].Value.ToString();
            txtboxExpense.Text = dgvServices.SelectedRows[0].Cells[3].Value.ToString();
        }

        #region Private/public Methods
        private void UpdateService()
        {
            var service = new Service()
            {
                Id = SelectedServiceId,
                Type = txtboxType.Text,
                Description = txtboxDescription.Text,
                Expense = decimal.Parse(txtboxExpense.Text)
            };

            mainForm.ServiceRepository.UpdateService(service);
        }
        public void LoadDgvServices()
        {
            dgvServices.DataSource = mainForm.ServiceRepository.GetAllServices();
        }
        #endregion
    }
}
