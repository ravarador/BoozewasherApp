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
            SummaryDateAndDateRangeDto dateAndDateRangeDto = new SummaryDateAndDateRangeDto();

            if(radSelectDate.Checked)
            {
                dateAndDateRangeDto.DateTime = datePickerSelectDate.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDate(dateAndDateRangeDto)
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
                dateAndDateRangeDto.DateTimeFrom = datePickerDateFromRange.Value.Date;
                dateAndDateRangeDto.DateTimeTo = datePickerDateToRange.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDateRange(dateAndDateRangeDto)
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
