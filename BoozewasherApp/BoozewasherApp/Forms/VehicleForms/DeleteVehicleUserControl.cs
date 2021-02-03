using BoozewasherDomain.Dtos;
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
    public partial class DeleteVehicleUserControl : UserControl
    {
        public MainForm mainForm;
        private int? SelectedVehicleId { get; set; }
        public DeleteVehicleUserControl()
        {
            InitializeComponent();
        }

        private void DeleteVehicleUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedVehicleId != null)
            {
                DeleteVehicle();
                LoadDgvVehicles();
            }
            else
            {
                MessageBox.Show("Select vehicle to delete!", "Error");
            }
            
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVehicleId = (int)dgvVehicles.SelectedRows[0].Cells[0].Value;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboSearchBy.SelectedItem != null)
            {
                SearchVehicles();
            }
            else
            {
                MessageBox.Show("Search By must not be empty.");
            }
        }

        #region Private/public Methods
        private void SearchVehicles()
        {
            var vehicles = mainForm.VehicleRepository.GetVehiclesBySearchParameter(new SearchDto
            {
                BranchId = mainForm.UserInformation.BranchId,
                SearchBy = comboSearchBy.SelectedItem.ToString(),
                SearchText = txtboxSearchText.Text
            });

            dgvVehicles.DataSource = vehicles;
        }
        private void DeleteVehicle()
        {
            mainForm.VehicleRepository.DeleteVehicle(SelectedVehicleId.Value);
            SelectedVehicleId = null;
        }
        public void LoadDgvVehicles()
        {
            dgvVehicles.DataSource = mainForm.VehicleRepository.GetAllVehicles();
        }

        #endregion

        
    }
}
