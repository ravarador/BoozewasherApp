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

namespace BoozewasherApp.Forms.VehicleForms
{
    public partial class UpdateVehicleUserControl : UserControl
    {
        private int SelectedVehicleId { get; set; }
        public MainForm mainForm;
        public UpdateVehicleUserControl()
        {
            InitializeComponent();
        }

        private void UpdateVehicleUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVehicle();
            LoadDgvVehicles();
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicles.SelectedRows[0].Cells[0].Value;

            txtboxType.Text = dgvVehicles.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvVehicles.SelectedRows[0].Cells[2].Value.ToString();
            txtboxBrand.Text = dgvVehicles.SelectedRows[0].Cells[3].Value.ToString();
            txtboxModel.Text = dgvVehicles.SelectedRows[0].Cells[4].Value.ToString();
        }
        #region Private/public Methods
        private void UpdateVehicle()
        {
            var vehicle = new Vehicle()
            {
                Id = SelectedVehicleId,
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            mainForm.VehicleRepository.UpdateVehicle(vehicle);
        }
        public void LoadDgvVehicles()
        {
            dgvVehicles.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }
        #endregion
    }
}
