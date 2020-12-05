using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Models.Dtos;
using BoozewasherApp.Queries.TransactionQueries;
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
        private IServiceRepository ServiceRepository { get; set; }
        private IVehicleRepository VehicleRepository { get; set; }
        public AddTransactionForm(IServiceRepository serviceRepository, 
                                  IVehicleRepository vehicleRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            comboServiceType.DataSource = GetServiceTypes();
            comboVehicleType.DataSource = GetVehicleTypes();
            //LoadDgvTransaction();
        }
        private void btnServiceLookup_Click(object sender, EventArgs e) => OpenServiceLookupForm();
        private void btnVehicleLookup_Click(object sender, EventArgs e) => OpenVehicleLookupForm();
        private void btnAdd_Click(object sender, EventArgs e) => AddTransaction();
        #region Private Methods
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
            return ServiceRepository.GetAllServices().Select(a => a.Id).ToList();
        }

        private List<int> GetVehicleTypes()
        {
            return VehicleRepository.GetAllVehicles().Select(a => a.Id).ToList();
        }
        private void LoadDgvTransaction()
        {
            var getTransaction = new GetAllTransactionsQuery();

            dgvTransaction.DataSource = getTransaction.GetAllTransactions()
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
            var serviceLookupForm = new ServiceLookupForm(ServiceRepository);
            serviceLookupForm.ShowDialog();
            comboServiceType.SelectedItem = serviceLookupForm.SelectedServiceIdForLookup;
        }
        private void OpenVehicleLookupForm()
        {
            var vehicleLookupForm = new VehicleLookupForm(VehicleRepository);
            vehicleLookupForm.ShowDialog();
            comboVehicleType.SelectedItem = vehicleLookupForm.SelectedVehicleIdForLookup;
        }
        #endregion

    }
}
