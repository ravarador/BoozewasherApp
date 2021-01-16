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
    public partial class AddVehicleUserControl : UserControl
    {
        public MainForm mainForm { get; set; }
        public AddVehicleUserControl()
        {
            InitializeComponent();
        }

        private void AddVehicleUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVehicle();
            LoadDgvVehicles();
        }
        #region Private/public Methods

        private void AddVehicle()
        {
            var vehicle = new Vehicle()
            {
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            VehicleValidator validator = new VehicleValidator();
            ValidationResult result = validator.Validate(vehicle);

            if (result.IsValid)
            {
                mainForm.VehicleRepository.AddVehicle(vehicle);
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
