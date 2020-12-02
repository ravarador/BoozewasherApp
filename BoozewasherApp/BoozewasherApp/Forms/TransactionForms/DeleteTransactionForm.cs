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
    public partial class DeleteTransactionForm : Form
    {
        private int SelectedTransactionId { get; set; }
        public DeleteTransactionForm()
        {
            InitializeComponent();
        }

        private void DeleteTransactionForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvTransaction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteTransactionById = new DeleteTransactionQuery();

            deleteTransactionById.DeleteTransaction(SelectedTransactionId);

            SetLabelsToEmpty();
            LoadDgvTransaction();
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedTransactionId = (int)dgvTransaction.SelectedRows[0].Cells[0].Value;

            var transactionById = new GetTransactionByIdQuery();

            var transaction = transactionById.GetTransactionById(SelectedTransactionId);

            lblDateTime.Text = transaction.DateTime.ToLongDateString();
            lblServiceId.Text = transaction.ServiceId.ToString();
            lblVehicleId.Text = transaction.VehicleId.ToString();
            lblPlateNumber.Text = transaction.PlateNumber;
            lblCost.Text = transaction.Cost.ToString();
        }
        #region Private Methods
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
        private void SetLabelsToEmpty()
        {
            lblCost.Text = null;
            lblDateTime.Text = null;
            lblPlateNumber.Text = null;
            lblServiceId.Text = null;
            lblVehicleId.Text = null;
        }
        #endregion
    }
}
