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
    public partial class UpdateTransactionForm : Form
    {
        private IServiceRepository ServiceRepository { get; set; }
        private IVehicleRepository VehicleRepository { get; set; }
        private ITransactionRepository TransactionRepository { get; set; }
        private IItemRepository ItemRepository { get; set; }
        private int SelectedTransactionId { get; set; }
        public UpdateTransactionForm(IServiceRepository serviceRepository,
                                     IVehicleRepository vehicleRepository,
                                     ITransactionRepository transactionRepository,
                                     IItemRepository itemRepository)
        {
            InitializeComponent();
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
        }

        private void UpdateTransactionForm_Load(object sender, EventArgs e)
        {
            comboServiceType.DataSource = GetServiceTypes();
            comboVehicleType.DataSource = GetVehicleTypes();
            LoadDgvTransaction();
        }
        private void btnServiceLookup_Click(object sender, EventArgs e) => OpenServiceLookupForm();
        private void btnVehicleLookup_Click(object sender, EventArgs e) => OpenVehicleLookupForm();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var transaction = new Transaction()
            {
                Id = SelectedTransactionId,
                DateTime = datepickerDateTime.Value,
                ServiceId = int.Parse(comboServiceType.SelectedItem.ToString()),
                VehicleId = int.Parse(comboVehicleType.SelectedItem.ToString()),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = decimal.Parse(txtboxCost.Text)
            };

            TransactionRepository.UpdateTransaction(transaction);

            LoadDgvTransaction();
        }
        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedTransactionId = (int)dgvTransaction.SelectedRows[0].Cells[0].Value;

            datepickerDateTime.Value = DateTime.Parse(dgvTransaction.SelectedRows[0].Cells[1].Value.ToString());
            txtboxPlateNumber.Text = dgvTransaction.SelectedRows[0].Cells[2].Value.ToString();
            comboServiceType.SelectedItem = dgvTransaction.SelectedRows[0].Cells[3].Value.ToString();
            comboVehicleType.SelectedItem = dgvTransaction.SelectedRows[0].Cells[4].Value.ToString();
            txtboxCost.Text = dgvTransaction.SelectedRows[0].Cells[5].Value.ToString();
        }
        #region Private Methods
        private void LoadDgvTransaction()
        {
            var transaction = = TransactionRepository.GetAllTransactions()
                                                      .Select(a => new TransactionDto
                                                      {
                                                          Id = a.Id,
                                                          DateTime = a.DateTime,
                                                          PlateNumber = a.PlateNumber,
                                                          ServiceType = a.Service.Type,
                                                          ServiceId = a.ServiceId,
                                                          VehicleType = a.Vehicle.Type,
                                                          VehicleId = a.VehicleId,
                                                          Cost = a.Cost,
                                                          ItemsList = a.ItemsList
                                                      }).ToList();

            dgvTransaction.DataSource = transaction;
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
        private List<int> GetServiceTypes()
        {
            return ServiceRepository.GetAllServices().Select(a => a.Id).ToList();
        }

        private List<int> GetVehicleTypes()
        {
            return VehicleRepository.GetAllVehicles().Select(a => a.Id).ToList();
        }
        #endregion
    }
}
