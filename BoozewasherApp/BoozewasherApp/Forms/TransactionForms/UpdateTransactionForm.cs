﻿using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.VehicleForms;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Models.Dtos;
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
    public partial class UpdateTransactionForm : Form
    {
        private int SelectedTransactionId { get; set; }
        public UpdateTransactionForm()
        {
            InitializeComponent();
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

            var updateTransaction = new UpdateTransactionQuery();

            updateTransaction.UpdateTransaction(transaction);

            LoadDgvTransaction();
        }
        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedTransactionId = (int)dgvTransaction.SelectedRows[0].Cells[0].Value;

            var transactionById = new GetTransactionByIdQuery();

            var transaction = transactionById.GetTransactionById(SelectedTransactionId);

            datepickerDateTime.Value = transaction.DateTime;
            comboServiceType.SelectedItem = transaction.ServiceId;
            comboVehicleType.SelectedItem = transaction.VehicleId;
            txtboxPlateNumber.Text = transaction.PlateNumber;
            txtboxCost.Text = transaction.Cost.ToString();
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
    }
}
