using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
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

namespace BoozewasherApp.Forms.TransactionForms
{
    public partial class AddTransactionUserControl : UserControl
    {
        public MainForm mainForm;
        public AddTransactionUserControl()
        {
            InitializeComponent();
        }

        private void AddTransactionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnServiceLookup_Click(object sender, EventArgs e)
        {
            OpenServiceLookupForm();
        }

        private void btnVehicleLookup_Click(object sender, EventArgs e)
        {
            OpenVehicleLookupForm();
        }

        private void btnItemLookup_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        #region Private Methods
        private void AddTransaction()
        {
            //var transaction = new Transaction()
            //{
            //    DateTime = DateTime.Now,
            //    ServiceId = int.Parse(comboServiceType.SelectedItem.ToString()),
            //    VehicleId = int.Parse(comboVehicleType.SelectedItem.ToString()),
            //    PlateNumber = txtboxPlateNumber.Text,
            //    Cost = decimal.Parse(txtboxCost.Text),
            //    ItemsList = ItemsListInForm

            //};

            //TransactionRepository.AddTransaction(transaction);

            //LoadDgvTransaction();
        }
        private List<int> GetServiceTypes()
        {
            return mainForm.ServiceRepository.GetAllServices().Select(a => a.Id).ToList();
        }

        private List<int> GetVehicleTypes()
        {
            return mainForm.VehicleRepository.GetAllVehicles().Select(a => a.Id).ToList();
        }
        public void LoadDgvTransactions()
        {
            dgvTransactions.DataSource = mainForm.TransactionRepository.GetAllTransactions()
                                                      .Select(a => new TransactionDto
                                                      {
                                                          Id = a.Id,
                                                          DateTime = a.DateTime,
                                                          PlateNumber = a.PlateNumber,
                                                          ServiceType = a.Service.Type,
                                                          ServiceId = a.ServiceId,
                                                          VehicleType = a.Vehicle.Type,
                                                          VehicleId = a.VehicleId,
                                                          Cost = a.Cost
                                                      }).ToList();
        }

        private void OpenServiceLookupForm()
        {
            var serviceLookupForm = new ServiceLookupForm(mainForm.ServiceRepository);
            serviceLookupForm.ShowDialog();
            txtboxService.Text = serviceLookupForm.SelectedServiceIdForLookup.ToString();
        }
        private void OpenVehicleLookupForm()
        {
            var vehicleLookupForm = new VehicleLookupForm(mainForm.VehicleRepository);
            vehicleLookupForm.ShowDialog();
            txtboxVehicle.Text = vehicleLookupForm.SelectedVehicleIdForLookup.ToString();
        }
        #endregion
    }
}
