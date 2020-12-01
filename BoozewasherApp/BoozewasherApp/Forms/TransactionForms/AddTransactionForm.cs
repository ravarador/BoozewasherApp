using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Queries.ServiceQueries;
using BoozewasherApp.Queries.TransactionQueries;
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

namespace BoozewasherApp.Forms.TransactionForms
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            comboServiceType.DataSource = GetServiceTypes();
            comboVehicleType.DataSource = GetVehicleTypes();
            LoadDgvTransaction();
        }
        private void btnServiceLookup_Click(object sender, EventArgs e) => OpenServiceLookupForm();
        private void btnVehicleLookup_Click(object sender, EventArgs e) => OpenVehicleLookupForm();
        private void btnAdd_Click(object sender, EventArgs e) => AddTransaction();
        private void AddTransaction()
        {
            var transaction = new Transaction()
            {
                DateTime = datepickerDateTime.Value,
                ServiceId = int.Parse(comboServiceType.SelectedItem.ToString()),
                VehicleId = int.Parse(comboVehicleType.SelectedItem.ToString()),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = decimal.Parse(txtboxCost.Text)
            };

            var addTransaction = new AddTransactionQuery();

            addTransaction.AddTransaction(transaction);

            LoadDgvTransaction();
        }
        private List<int> GetServiceTypes()
        {
            var getServices = new GetAllServicesQuery();

            return getServices.GetAllServices().Select(a => a.Id).ToList();
        }

        private List<int> GetVehicleTypes()
        {
            var getVehicles = new GetAllVehiclesQuery();

            return getVehicles.GetAllVehicles().Select(a => a.Id).ToList();
        }
        private void LoadDgvTransaction()
        {
            var getTransaction = new GetAllTransactionsQuery();

            dgvTransaction.DataSource = getTransaction.GetAllTransactions();
        }

        private void OpenServiceLookupForm()
        {
            var serviceLookupForm = new ServiceLookupForm();
            serviceLookupForm.ShowDialog();
            comboServiceType.SelectedItem = serviceLookupForm.SelectedServiceIdForLookup;
        }
        private void OpenVehicleLookupForm()
        {
            var vehicleLookupForm = new VehicleLookupForm();
            vehicleLookupForm.ShowDialog();
            comboVehicleType.SelectedItem = vehicleLookupForm.SelectedVehicleIdForLookup;
        }

        
    }
}
