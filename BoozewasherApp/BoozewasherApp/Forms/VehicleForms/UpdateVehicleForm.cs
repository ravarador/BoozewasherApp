using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Queries.VehicleQueries;
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
        private int SelectedVehicleId { get; set; }
        public UpdateVehicleForm()
        {
            InitializeComponent();
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

            var updateVehicle = new UpdateVehicleQuery();

            updateVehicle.UpdateVehicle(vehicle);

            LoadDgvVehicle();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicle.SelectedRows[0].Cells[0].Value;

            var vehicleById = new GetVehicleByIdQuery();

            var vehicle = vehicleById.GetVehicleById(SelectedVehicleId);

            txtboxType.Text = vehicle.Type;
            txtboxBrand.Text = vehicle.Brand;
            txtboxModel.Text = vehicle.Model;
            txtboxDescription.Text = vehicle.Description;
        }
        private void LoadDgvVehicle()
        {
            var getVehicles = new GetAllVehiclesQuery();

            dgvVehicle.DataSource = getVehicles.GetAllVehicles();
        }
    }
}
