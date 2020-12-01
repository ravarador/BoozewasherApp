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
    public partial class DeleteServiceForm : Form
    {
        private int SelectedServiceId { get; set; }
        public DeleteServiceForm()
        {
            InitializeComponent();
        }

        private void DeleteServiceForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvService();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteServiceById = new DeleteServiceQuery();

            deleteServiceById.DeleteService(SelectedServiceId);

            SetLabelsToEmpty();
            LoadDgvService();
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvService.SelectedRows[0].Cells[0].Value;

            var serviceById = new GetServiceByIdQuery();

            var service = serviceById.GetServiceById(SelectedServiceId);

            lblDescription.Text = service.Description;
            lblType.Text = service.Type;
            lblExpense.Text = service.Expense.ToString();
        }
        private void LoadDgvService()
        {
            var getServices = new GetAllServicesQuery();

            dgvService.DataSource = getServices.GetAllServices();
        }

        private void SetLabelsToEmpty()
        {
            lblDescription.Text = null;
            lblExpense.Text = null;
            lblType.Text = null;
        }
    }
}
