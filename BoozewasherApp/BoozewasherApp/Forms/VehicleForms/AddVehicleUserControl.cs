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

            mainForm.VehicleRepository.AddVehicle(vehicle);
        }

        public void LoadDgvVehicles()
        {
            dgvVehicles.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }

        #endregion
    }
}
