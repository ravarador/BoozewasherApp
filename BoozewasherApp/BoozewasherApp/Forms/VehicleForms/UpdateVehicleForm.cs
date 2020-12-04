using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.ContextModels;
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
    public partial class UpdateVehicleForm : Form
    {
        private IVehicleRepository VehicleRepository { get; set; }
        private int SelectedVehicleId { get; set; }
        public UpdateVehicleForm(IVehicleRepository vehicleRepository)
        {
            InitializeComponent();
            VehicleRepository = vehicleRepository;
        }

        private void UpdateVehicleForm_Load(object sender, EventArgs e)
        {
            LoadDgvVehicle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle()
            {
                Id = SelectedVehicleId,
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            VehicleRepository.UpdateVehicle(vehicle);

            LoadDgvVehicle();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicle.SelectedRows[0].Cells[0].Value;

            txtboxType.Text = dgvVehicle.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvVehicle.SelectedRows[0].Cells[2].Value.ToString();
            txtboxBrand.Text = dgvVehicle.SelectedRows[0].Cells[3].Value.ToString();
            txtboxModel.Text = dgvVehicle.SelectedRows[0].Cells[4].Value.ToString();

        }
        #region Private Methods
        private void LoadDgvVehicle()
        {
            dgvVehicle.DataSource = VehicleRepository.GetAllVehicles();
        }
        #endregion
    }
}
