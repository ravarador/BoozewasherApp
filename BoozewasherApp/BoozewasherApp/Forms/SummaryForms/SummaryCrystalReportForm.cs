using BoozewasherApp.Helpers;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Models.Dtos;
using BoozewasherApp.Reports;
using CrystalDecisions.Windows.Forms;
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
