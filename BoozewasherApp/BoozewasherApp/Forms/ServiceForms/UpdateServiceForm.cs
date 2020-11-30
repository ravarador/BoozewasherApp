using BoozewasherApp.Queries.ServiceQueries;
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
        private int SelectedServiceId { get; set; }
        public UpdateServiceForm()
        {
            InitializeComponent();
        }
        private void UpdateServiceForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvService.SelectedRows[0].Cells[0].Value;

            var serviceById = new GetServiceByIdQuery();

            var service = serviceById.GetServiceById(SelectedServiceId);

            txtboxDescription.Text = service.Description;
            txtboxType.Text = service.Type;
            txtboxExpense.Text = service.Expense.ToString();
        }
        private void LoadDgvService()
        {
            var updateService = new GetAllServicesQuery();

            dgvService.DataSource = updateService.GetAllServices();
        }
    }
}
