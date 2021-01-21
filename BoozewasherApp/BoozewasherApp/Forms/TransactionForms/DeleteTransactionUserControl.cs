﻿using BoozewasherDomain.Dtos;
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
    public partial class DeleteTransactionUserControl : UserControl
    {
        public MainForm mainForm;
        private int? SelectedTransactionId { get; set; }
        public DeleteTransactionUserControl()
        {
            InitializeComponent();
        }

        private void DeleteTransactionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedTransactionId = (int)dgvTransactions.SelectedRows[0].Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedTransactionId != null)
            {
                DeleteTransaction();
                LoadDgvTransactions();
            }
            else
            {
                MessageBox.Show("Select transaction to delete!", "Error");
            }
            
        }

        #region Private/public Methods
        private void DeleteTransaction()
        {
            mainForm.TransactionRepository.DeleteTransaction(SelectedTransactionId.Value);
        }
        public void LoadDgvTransactions()
        {
            dgvTransactions.DataSource = mainForm.TransactionRepository.GetTransactionsByBranchId(mainForm.UserInformation.BranchId);
        }

        #endregion
    }
}
