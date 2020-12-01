using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();

            addServiceForm.Show();
            addServiceForm.MdiParent = this;
        }

        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateServiceForm updateServiceForm = new UpdateServiceForm();

            updateServiceForm.Show();
            updateServiceForm.MdiParent = this;
        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteServiceForm deleteServiceForm = new DeleteServiceForm();

            deleteServiceForm.Show();
            deleteServiceForm.MdiParent = this;
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();

            addVehicleForm.Show();
            addVehicleForm.MdiParent = this;
        }
    }
}
