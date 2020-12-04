using BoozewasherApp.IRepositories;
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
        private IVehicleRepository VehicleRepository { get; set; }
        private int SelectedVehicleId { get; set; }
        public DeleteVehicleForm(IVehicleRepository vehicleRepository)
        {
            InitializeComponent();
            VehicleRepository = vehicleRepository;
        }

        private void DeleteVehicleForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvVehicle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            VehicleRepository.DeleteVehicle(SelectedVehicleId);

            SetLabelsToEmpty();
            LoadDgvVehicle();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicle.SelectedRows[0].Cells[0].Value;

            lblType.Text = dgvVehicle.SelectedRows[0].Cells[1].Value.ToString();
            lblDescription.Text = dgvVehicle.SelectedRows[0].Cells[2].Value.ToString();
            lblBrand.Text = dgvVehicle.SelectedRows[0].Cells[3].Value.ToString();
            lblModel.Text = dgvVehicle.SelectedRows[0].Cells[4].Value.ToString();
            
        }
        #region Private Methods
        private void LoadDgvVehicle()
        {
            dgvVehicle.DataSource = VehicleRepository.GetAllVehicles();
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
