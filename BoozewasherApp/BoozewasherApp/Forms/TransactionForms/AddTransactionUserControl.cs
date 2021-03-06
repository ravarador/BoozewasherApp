﻿using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
using FluentValidation.Results;
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
            //SetColumnsOfItemDgv();
        }

        private void btnServiceLookup_Click(object sender, EventArgs e) => OpenServiceLookupForm();
        private void btnVehicleLookup_Click(object sender, EventArgs e) => OpenVehicleLookupForm();
        private void btnItemLookup_Click(object sender, EventArgs e) => OpenItemLookupForm();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxService.Text) || string.IsNullOrWhiteSpace(txtboxVehicle.Text))
            {
                if (string.IsNullOrWhiteSpace(txtboxService.Text) && string.IsNullOrWhiteSpace(txtboxVehicle.Text))
                {
                    MessageBox.Show("Please select vehicle and service", "Error");
                }
                else if (string.IsNullOrWhiteSpace(txtboxVehicle.Text))
                {
                    MessageBox.Show("Please select a vehicle", "Error");
                }
                else
                {
                    MessageBox.Show("Please select a service.", "Error");
                }
                
            }
            else
            {
                AddTransaction();
                LoadDgvTransactions();
            }
        }

        #region Private/public Methods
        private void AddTransaction()
        {
            var transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                ServiceId = int.Parse(txtboxService.Text),
                VehicleId = int.Parse(txtboxVehicle.Text),
                PlateNumber = txtboxPlateNumber.Text,
                Cost = numericCost.Value,
                ItemsList = ItemsListInForm,
                BranchId = mainForm.UserInformation.BranchId

            };

            TransactionValidator validator = new TransactionValidator();
            ValidationResult result = validator.Validate(transaction);

            if (result.IsValid)
            {
                mainForm.TransactionRepository.AddTransaction(transaction);
                ResetFields();
            }
            else
            {
                MessageBox.Show(result.ToString());
            }

        }
        public void LoadDgvTransactions()
        {
            dgvTransactions.DataSource = mainForm.TransactionRepository.GetTransactionsByBranchId(mainForm.UserInformation.BranchId);
        }

        private void OpenServiceLookupForm()
        {
            var serviceLookupForm = new ServiceLookupForm();
            serviceLookupForm.mainForm = mainForm;
            serviceLookupForm.ShowDialog();
            txtboxService.Text = serviceLookupForm.SelectedServiceIdForLookup.ToString();
        }
        private void OpenVehicleLookupForm()
        {
            var vehicleLookupForm = new VehicleLookupForm();
            vehicleLookupForm.mainForm = mainForm;
            vehicleLookupForm.ShowDialog();
            txtboxVehicle.Text = vehicleLookupForm.SelectedVehicleIdForLookup.ToString();
        }
        private void OpenItemLookupForm()
        {
            var itemLookupForm = new ItemLookupForm();
            itemLookupForm.mainForm = mainForm;
            itemLookupForm.ShowDialog();

            if (string.IsNullOrEmpty(ItemsListInForm))
            {
                ItemsListInForm += itemLookupForm.SelectedItemIdForLookup.ToString();
            }
            else
            {
                ItemsListInForm += "," + itemLookupForm.SelectedItemIdForLookup.ToString();
            }

            if (itemLookupForm.SelectedItem != null)
            {
                dgvItemsList.Rows.Add(itemLookupForm.SelectedItem.Name,
                                   itemLookupForm.SelectedItem.UsageCount,
                                   itemLookupForm.SelectedItem.IsEmpty);
            }
            
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
