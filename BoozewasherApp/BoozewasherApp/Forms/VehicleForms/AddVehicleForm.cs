using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Queries.ServiceQueries;
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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
            LoadDgvVehicle();
        }

        private void btnAdd_Click(object sender, EventArgs e) => AddVehicle();

        #region Private Methods

        private void AddVehicle()
        {
            var vehicle = new Vehicle()
            {
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            var addVehicle = new AddVehicleQuery();

            addVehicle.AddVehicle(vehicle);

            LoadDgvVehicle();
        }

        private void LoadDgvVehicle()
        {
            var updateVehicle = new GetAllVehiclesQuery();

            dgvVehicle.DataSource = updateVehicle.GetAllVehicles();
        }

        #endregion
    }
}
