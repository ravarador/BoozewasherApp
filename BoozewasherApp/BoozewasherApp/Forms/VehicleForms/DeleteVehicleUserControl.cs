using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.VehicleForms
{
    public partial class DeleteVehicleUserControl : UserControl
    {
        public MainForm mainForm;
        private int SelectedVehicleId { get; set; }
        public DeleteVehicleUserControl()
        {
            InitializeComponent();
        }

        private void DeleteVehicleUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.VehicleRepository.DeleteVehicle(SelectedVehicleId);

            LoadDgvVehicles();
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicles.SelectedRows[0].Cells[0].Value;
        }

        #region Private Methods
        public void LoadDgvVehicles()
        {
            dgvVehicles.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }

        #endregion
    }
}
