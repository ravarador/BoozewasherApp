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
    public partial class DeleteServiceForm : Form
    {
        private IServiceRepository ServiceRepository { get; set; }
        private int SelectedServiceId { get; set; }
        public DeleteServiceForm(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
        }

        private void DeleteServiceForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvService();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceRepository.DeleteService(SelectedServiceId);

            SetLabelsToEmpty();
            LoadDgvService();
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvService.SelectedRows[0].Cells[0].Value;

            lblType.Text = dgvService.SelectedRows[0].Cells[1].Value.ToString();
            lblDescription.Text = dgvService.SelectedRows[0].Cells[2].Value.ToString();
            lblExpense.Text = dgvService.SelectedRows[0].Cells[3].Value.ToString();
        }
        #region Private Methods
        private void LoadDgvService()
        {
            dgvService.DataSource = ServiceRepository.GetAllServices();
        }

        private void SetLabelsToEmpty()
        {
            lblDescription.Text = null;
            lblExpense.Text = null;
            lblType.Text = null;
        }
        #endregion
    }
}
