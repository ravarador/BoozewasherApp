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

namespace BoozewasherApp.Forms.SummaryForms
{
    public partial class SummaryReportSelector : Form
    {
        private ITransactionRepository TransactionRepository { get; set; }
        public SummaryReportSelector(ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            TransactionRepository = transactionRepository;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var transactionList = TransactionRepository.GetAllTransactions()
                                                      .Select(a => new SummaryDto
                                                      {
                                                          Id = a.Id,
                                                          DateTime = a.DateTime,
                                                          PlateNumber = a.PlateNumber,
                                                          ServiceType = a.Service.Type,
                                                          Expense = a.Service.Expense.Value,
                                                          VehicleType = a.Vehicle.Type,
                                                          Brand = a.Vehicle.Brand,
                                                          Model = a.Vehicle.Model,
                                                          Cost = a.Cost
                                                      }).ToList();

            var summaryCrystalReportForm = new SummaryCrystalReportForm(transactionList);
            summaryCrystalReportForm.ShowDialog();
        }
    }
}
