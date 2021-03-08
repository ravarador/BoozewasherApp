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

namespace BoozewasherApp.Forms.ServiceForms
{
    public partial class ServiceLookupForm : Form
    {
        public MainForm mainForm { get; set; }
        public int? SelectedServiceIdForLookup { get; set; }
        public ServiceLookupForm()
        {
            InitializeComponent();
        }

        private void ServiceLookupForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchServices();
        }
        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceIdForLookup = (int)dgvService.SelectedRows[0].Cells[0].Value;

            this.Close();
        }

        #region Private Methods
        private void SearchServices()
        {
            var services = mainForm.ServiceRepository.GetServicesBySearchParameter(new SearchDto
            {
                BranchId = mainForm.UserInformation.BranchId,
                SearchBy = comboSearchBy.SelectedItem.ToString(),
                SearchText = txtboxSearchText.Text
            });

            dgvService.DataSource = services;
        }
        private void LoadDgvService()
        {
            dgvService.DataSource = mainForm.ServiceRepository.GetAllServices();
        }
        #endregion

        
    }
}
