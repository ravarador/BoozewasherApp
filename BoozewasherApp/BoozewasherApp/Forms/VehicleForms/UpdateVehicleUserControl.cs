using BoozewasherDomain.Entities;
using FluentValidation.Results;
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
        private int? SelectedVehicleId { get; set; }
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
            if (SelectedVehicleId != null)
            {
                UpdateVehicle();
                LoadDgvVehicles();
            }
            else
            {
                MessageBox.Show("Select an item to update!", "Error");
            }
            
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
                Id = SelectedVehicleId.Value,
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            VehicleValidator validator = new VehicleValidator();
            ValidationResult result = validator.Validate(vehicle);

            if (result.IsValid)
            {
                mainForm.VehicleRepository.UpdateVehicle(vehicle);
                ResetFields();
            }
            else
            {
                MessageBox.Show(result.ToString());
            }
            
        }
        public void ResetFields()
        {
            txtboxType.Text = string.Empty;
            txtboxBrand.Text = string.Empty;
            txtboxModel.Text = string.Empty;
            txtboxDescription.Text = string.Empty;
        }
        public void LoadDgvVehicles()
        {
            dgvVehicles.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }
        #endregion
    }
}
