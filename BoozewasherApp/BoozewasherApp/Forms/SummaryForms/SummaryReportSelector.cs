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
        private List<SummaryDto> SummaryList { get; set; }
        public SummaryReportSelector(ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            TransactionRepository = transactionRepository;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            TransactionDto transactionDto = new TransactionDto();

            if(radSelectDate.Checked)
            {
                transactionDto.DateTime = datePickerSelectDate.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDate(transactionDto)
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
            }
            else
            {
                transactionDto.DateTimeFrom = datePickerDateFromRange.Value.Date;
                transactionDto.DateTimeTo = datePickerDateToRange.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDateRange(transactionDto)
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
            }

            var summaryCrystalReportForm = new SummaryCrystalReportForm(SummaryList);
            summaryCrystalReportForm.ShowDialog();
        }

        private void radSelectDateRange_Click(object sender, EventArgs e)
        {
            if (radSelectDate.Checked)
            {
                grpboxDate.Enabled = true;
                grpboxDateRange.Enabled = false;
            }
            else if (radSelectDateRange.Checked)
            {
                grpboxDate.Enabled = false;
                grpboxDateRange.Enabled = true;
            }
        }
    }
}
