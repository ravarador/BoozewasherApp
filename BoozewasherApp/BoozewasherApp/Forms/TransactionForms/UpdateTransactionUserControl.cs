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
    public partial class UpdateTransactionUserControl : UserControl
    {
        public MainForm mainForm;
        private string ItemsListInForm;
        private int SelectedTransactionId { get; set; }
        public UpdateTransactionUserControl()
        {
            InitializeComponent();
        }

        private void UpdateTransactionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnServiceLookup_Click(object sender, EventArgs e) => OpenServiceLookupForm();

        private void btnVehicleLookup_Click(object sender, EventArgs e) => OpenVehicleLookupForm();

        private void btnItemLookup_Click(object sender, EventArgs e) => OpenItemLookupForm();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTransaction();
            LoadDgvTransactions();
            ResetFields();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetFields();

            SelectedTransactionId = (int)dgvTransactions.SelectedRows[0].Cells[0].Value;

            dateTimePicker1.Value = DateTime.Parse(dgvTransactions.SelectedRows[0].Cells[1].Value.ToString());
            txtboxPlateNumber.Text = dgvTransactions.SelectedRows[0].Cells[2].Value.ToString();
            txtboxService.Text = dgvTransactions.SelectedRows[0].Cells[5].Value.ToString();
            txtboxVehicle.Text = dgvTransactions.SelectedRows[0].Cells[6].Value.ToString();
            numericCost.Text = dgvTransactions.SelectedRows[0].Cells[7].Value.ToString();

            ItemsListInForm = dgvTransactions.SelectedRows[0].Cells[8].Value.ToString();

            if (!string.IsNullOrEmpty(ItemsListInForm))
            {
                var itemsArray = ItemsListInForm.Split(',');

                foreach (var itemFromArray in itemsArray)
                {
                    var item = mainForm.ItemRepository.GetItemById(int.Parse(itemFromArray));
                    dgvItemsList.Rows.Add(item.Name, item.UsageCount, item.IsEmpty);
                }
            }
        }

        #region Private/public Methods
        private void UpdateTransaction()
        {
            var transaction = new Transaction()
            {
                Id = SelectedTransactionId,
                DateTime = DateTime.Now,
                ServiceId = int.Parse(txtboxService.Text),
                VehicleId = int.Parse(txtboxVehicle.Text),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = numericCost.Value,
                ItemsList = ItemsListInForm

            };

            mainForm.TransactionRepository.UpdateTransaction(transaction);
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

            dgvItemsList.Rows.Add(itemLookupForm.SelectedItem.Name,
                                   itemLookupForm.SelectedItem.UsageCount,
                                   itemLookupForm.SelectedItem.IsEmpty);
        }
        public void SetColumnsOfItemDgv()
        {
            dgvItemsList.Columns.Clear();
            dgvItemsList.Columns.Add("Name", "Name");
            dgvItemsList.Columns.Add("UsageCount", "Usage");
            dgvItemsList.Columns.Add("IsEmpty", "Is Empty?");
        }
        public void ResetFields()
        {
            //dataGridView1.DataSource = null;
            txtboxService.Text = string.Empty;
            txtboxVehicle.Text = string.Empty;
            txtboxPlateNumber.Text = string.Empty;
            numericCost.Value = 0.00m;
            ItemsListInForm = string.Empty;
            dgvItemsList.Rows.Clear();
        }
        #endregion
    }
}
