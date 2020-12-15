
using BoozewasherApp.Helpers;
using BoozewasherApp.Reports;
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Enums;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.SummaryForms
{
    public partial class SummaryCrystalReportForm : Form
    {
        private List<SummaryDto> _dataList;
        public SummaryCrystalReportForm(List<SummaryDto> dataList)
        {
            InitializeComponent();
            _dataList = dataList;
        }

        private void SummaryCrystalReportForm_Load(object sender, EventArgs e)
        {
            #region Summary Computations
            //COUNT COMPUTATIONS
            var carwashCount = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Count();
            var detailingCount = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Count();
            var paintjobCount = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Count();
            var backtozeroCount = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Count();
            var overallTotalCount = carwashCount + detailingCount + paintjobCount + backtozeroCount;

            //COST COMPUTATIONS
            var carwashTotalCost = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Sum(a => a.Cost);
            var detailingTotalCost = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Sum(a => a.Cost);
            var paintjobTotalCost = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Sum(a => a.Cost);
            var backtozeroTotalCost = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Sum(a => a.Cost);
            var overallTotalCost = carwashTotalCost + detailingTotalCost + paintjobTotalCost + backtozeroTotalCost;

            //EXPENSE COMPUTATIONS
            var carwashTotalExpense = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Sum(a => a.Expense);
            var detailingTotalExpense = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Sum(a => a.Expense);
            var paintjobTotalExpense = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Sum(a => a.Expense);
            var backtozeroTotalExpense = _dataList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Sum(a => a.Expense);
            var overallTotalExpense = carwashTotalExpense + detailingTotalExpense + paintjobTotalExpense + backtozeroTotalExpense;

            //PROFIT COMPUTATIONS
            var grossProfit = overallTotalCost - overallTotalExpense;
            var netProfit = grossProfit - (grossProfit * TaxConstants.BusinessTax);
            #endregion

            _dataList.ForEach(a => a.CarwashCount = carwashCount);
            _dataList.ForEach(a => a.DetailingCount = detailingCount);
            _dataList.ForEach(a => a.PaintjobCount = paintjobCount);
            _dataList.ForEach(a => a.BackToZeroCount = backtozeroCount);
            _dataList.ForEach(a => a.OverallTotalCount = overallTotalCount);

            _dataList.ForEach(a => a.CarwashTotalCost = carwashTotalCost);
            _dataList.ForEach(a => a.DetailingTotalCost = detailingTotalCost);
            _dataList.ForEach(a => a.PaintjobTotalCost = paintjobTotalCost);
            _dataList.ForEach(a => a.BackToZeroTotalCost = backtozeroTotalCost);
            _dataList.ForEach(a => a.OverallTotalCost = overallTotalCost);

            _dataList.ForEach(a => a.CarwashTotalExpense = carwashTotalExpense);
            _dataList.ForEach(a => a.DetailingTotalExpense = detailingTotalExpense);
            _dataList.ForEach(a => a.PaintjobTotalExpense = paintjobTotalExpense);
            _dataList.ForEach(a => a.BackToZeroTotalExpense = backtozeroTotalExpense);
            _dataList.ForEach(a => a.OverallTotalExpense = overallTotalExpense);


            _dataList.ForEach(a => a.GrossProfit = grossProfit);
            _dataList.ForEach(a => a.NetProfit = netProfit);

            var summaryDataSet = _dataList.ToDataSet();
            var summaryReport = new SummaryReport();
            summaryReport.SetDataSource(summaryDataSet.Tables[0]);
            this.crystalReportViewer1.ReportSource = summaryReport;
            this.crystalReportViewer1.Zoom(2);
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
    }
}
