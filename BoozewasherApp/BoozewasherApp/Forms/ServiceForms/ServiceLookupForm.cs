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
        private IServiceRepository ServiceRepository { get; set; }
        public int? SelectedServiceIdForLookup { get; set; }
        public ServiceLookupForm(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
        }

        private void ServiceLookupForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedServiceIdForLookup = (int)dgvService.SelectedRows[0].Cells[0].Value;

            this.Close();
        }
        #region Private Methods
        private void LoadDgvService()
        {
            dgvService.DataSource = ServiceRepository.GetAllServices();
        }
        #endregion
    }
}
