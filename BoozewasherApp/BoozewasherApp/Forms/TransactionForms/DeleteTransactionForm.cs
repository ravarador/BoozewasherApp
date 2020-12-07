using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.Dtos;
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
        private ITransactionRepository TransactionRepository { get; set; }
        private int SelectedTransactionId { get; set; }
        public DeleteTransactionForm(ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            TransactionRepository = transactionRepository;
        }

        private void DeleteTransactionForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvTransaction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TransactionRepository.DeleteTransaction(SelectedTransactionId);

            SetLabelsToEmpty();
            LoadDgvTransaction();
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedTransactionId = (int)dgvTransaction.SelectedRows[0].Cells[0].Value;

            lblDateTime.Text = dgvTransaction.SelectedRows[0].Cells[1].Value.ToString();
            lblPlateNumber.Text = dgvTransaction.SelectedRows[0].Cells[2].Value.ToString();
            lblServiceId.Text = dgvTransaction.SelectedRows[0].Cells[3].Value.ToString();
            lblVehicleId.Text = dgvTransaction.SelectedRows[0].Cells[4].Value.ToString();
            lblCost.Text = dgvTransaction.SelectedRows[0].Cells[5].Value.ToString();
        }
        #region Private Methods
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
