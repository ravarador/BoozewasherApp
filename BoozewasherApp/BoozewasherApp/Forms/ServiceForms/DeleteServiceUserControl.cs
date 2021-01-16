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
    public partial class DeleteServiceUserControl : UserControl
    {
        public MainForm mainForm;
        private int? SelectedServiceId { get; set; }
        public DeleteServiceUserControl()
        {
            InitializeComponent();
        }

        private void DeleteServiceUserControl_Load(object sender, EventArgs e)
        {

        }
        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceId = (int)dgvServices.SelectedRows[0].Cells[0].Value;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedServiceId != null)
            {
                DeleteService();
                LoadDgvServices();
            }
            else
            {
                MessageBox.Show("Select service to delete!", "Error");
            }
        }

        #region Private/public Methods
        private void DeleteService()
        {
            mainForm.ServiceRepository.DeleteService(SelectedServiceId.Value);
        }
        public void LoadDgvServices()
        {
            dgvServices.DataSource = mainForm.ServiceRepository.GetAllServices();
        }
        #endregion
    }
}
