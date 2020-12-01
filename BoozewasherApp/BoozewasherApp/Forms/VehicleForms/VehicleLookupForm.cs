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
    public partial class VehicleLookupForm : Form
    {
        public int SelectedVehicleIdForLookup { get; set; }
        public VehicleLookupForm()
        {
            InitializeComponent();
        }

        private void VehicleLookupForm_Load(object sender, EventArgs e)
        {
            LoadDgvVehicle();
        }

        private void dgvVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleIdForLookup = (int)dgvVehicle.SelectedRows[0].Cells[0].Value;

            this.Close();
        }
        private void LoadDgvVehicle()
        {
            var getVehicle = new GetAllVehiclesQuery();

            dgvVehicle.DataSource = getVehicle.GetAllVehicles();
        }
    }
}
