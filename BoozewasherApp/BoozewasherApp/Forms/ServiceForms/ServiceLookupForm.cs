using BoozewasherApp.Queries.ServiceQueries;
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
        public int SelectedServiceIdForLookup { get; set; }
        public ServiceLookupForm()
        {
            InitializeComponent();
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
        private void LoadDgvService()
        {
            var getService = new GetAllServicesQuery();

            dgvService.DataSource = getService.GetAllServices();
        }
    }
}
