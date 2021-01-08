using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
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
        private string ItemsListInForm;
        public AddTransactionUserControl()
        {
            InitializeComponent();
        }

        private void AddTransactionUserControl_Load(object sender, EventArgs e)
        {
            SetColumnsOfItemDgv();
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
            OpenItemLookupForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        #region Private Methods
        private void AddTransaction()
        {
            var transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                ServiceId = int.Parse(txtboxService.Text),
                VehicleId = int.Parse(txtboxVehicle.Text),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = numericCost.Value,
                ItemsList = ItemsListInForm

            };

            mainForm.TransactionRepository.AddTransaction(transaction);

            LoadDgvTransactions();
            ResetFields();
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
                                                          Cost = a.Cost,
                                                          ItemsList = a.ItemsList
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
        private void OpenItemLookupForm()
        {
            var itemLookupForm = new ItemLookupForm(mainForm.ItemRepository);
            itemLookupForm.ShowDialog();

            if (string.IsNullOrEmpty(ItemsListInForm))
            {
                ItemsListInForm += itemLookupForm.SelectedItemIdForLookup.ToString();
            }
            else
            {
                ItemsListInForm += "," + itemLookupForm.SelectedItemIdForLookup.ToString();
            }

            dataGridView1.Rows.Add(itemLookupForm.SelectedItem.Name, 
                                   itemLookupForm.SelectedItem.UsageCount, 
                                   itemLookupForm.SelectedItem.IsEmpty);
        }
        private void SetColumnsOfItemDgv()
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("UsageCount", "Usage");
            dataGridView1.Columns.Add("IsEmpty", "Is Empty?");
        }
        public void ResetFields()
        {
            txtboxService.Text = string.Empty;
            txtboxVehicle.Text = string.Empty;
            txtboxPlateNumber.Text = string.Empty;
            numericCost.Value = 0.00m;
            ItemsListInForm = string.Empty;
            dataGridView1.Rows.Clear();
        }
        #endregion
    }
}
