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
    public partial class DeleteVehicleForm : Form
    {
        private int SelectedVehicleId { get; set; }
        public DeleteVehicleForm()
        {
            InitializeComponent();
        }

        private void DeleteVehicleForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvVehicle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteVehicleById = new DeleteVehicleQuery();

            deleteVehicleById.DeleteVehicle(SelectedVehicleId);

            SetLabelsToEmpty();
            LoadDgvVehicle();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicle.SelectedRows[0].Cells[0].Value;

            var vehicleById = new GetVehicleByIdQuery();

            var vehicle = vehicleById.GetVehicleById(SelectedVehicleId);

            lblType.Text = vehicle.Type;
            lblBrand.Text = vehicle.Brand;
            lblModel.Text = vehicle.Model;
            lblDescription.Text = vehicle.Description;
        }
        #region Private Methods
        private void LoadDgvVehicle()
        {
            var getVehicles = new GetAllVehiclesQuery();

            dgvVehicle.DataSource = getVehicles.GetAllVehicles();
        }

        private void SetLabelsToEmpty()
        {
            lblType.Text = null;
            lblBrand.Text = null;
            lblModel.Text = null;
            lblDescription.Text = null;
        }
        #endregion
    }
}
