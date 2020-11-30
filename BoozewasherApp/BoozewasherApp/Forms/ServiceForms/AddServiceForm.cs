using BoozewasherApp.Models.ContextModels;
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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }
        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            LoadDgvService();
        }
        private void btnAdd_Click(object sender, EventArgs e) => AddService();

        #region Private Methods

        private void AddService()
        {
            var service = new Service()
            {
                Type = txtboxType.Text,
                Description = txtboxDescription.Text,
                Expense = decimal.Parse(txtboxExpense.Text)
            };

            var addService = new AddServiceQuery();

            addService.AddService(service);

            LoadDgvService();
        }

        private void LoadDgvService()
        {
            var updateService = new GetAllServiceQuery();

            dgvService.DataSource = updateService.GetAllService();
        }

        #endregion
    }
}
