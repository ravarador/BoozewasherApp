using BoozewasherDomain.Dtos;
using BoozewasherDomain.IRepositories;
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
        public MainForm mainForm { get; set; }
        public int? SelectedVehicleIdForLookup { get; set; }
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchVehicles();
        }

        #region Private Methods
        private void SearchVehicles()
        {
            var vehicles = mainForm.VehicleRepository.GetVehiclesBySearchParameter(new SearchDto
            {
                BranchId = mainForm.UserInformation.BranchId,
                SearchBy = comboSearchBy.SelectedItem.ToString(),
                SearchText = txtboxSearchText.Text
            });

            dgvVehicle.DataSource = vehicles;
        }
        private void LoadDgvVehicle()
        {
            dgvVehicle.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }
        #endregion


    }
}
