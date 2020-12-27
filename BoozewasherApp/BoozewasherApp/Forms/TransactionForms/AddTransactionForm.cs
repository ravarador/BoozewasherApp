using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
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

namespace BoozewasherApp.Forms.TransactionForms
{
    public partial class AddTransactionForm : Form
    {
        private IServiceRepository ServiceRepository { get; set; }
        private IVehicleRepository VehicleRepository { get; set; }
        private ITransactionRepository TransactionRepository { get; set; }
        private IItemRepository ItemRepository { get; set; }
        private List<Item> ItemsList { get; set; }
        public AddTransactionForm(IServiceRepository serviceRepository, 
                                  IVehicleRepository vehicleRepository,
                                  ITransactionRepository transactionRepository,
                                  IItemRepository itemRepository)
        {
            InitializeComponent();
            ItemsList = null;
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
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
        #region Private Methods
        private void AddTransaction()
        {
            var transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                ServiceId = int.Parse(comboServiceType.SelectedItem.ToString()),
                VehicleId = int.Parse(comboVehicleType.SelectedItem.ToString()),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = decimal.Parse(txtboxCost.Text)
            };

            TransactionRepository.AddTransaction(transaction);

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
            dgvTransaction.DataSource = TransactionRepository.GetAllTransactions()
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

        private void btnItemLookup_Click(object sender, EventArgs e)
        {
            var itemLookupForm = new ItemLookupForm(ItemRepository);
            itemLookupForm.ShowDialog();
            
            //ItemsList.Add(ItemRepository.)
        }
    }
}
