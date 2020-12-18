using BoozewasherDomain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Sales;
            lblTabTitle.Text = "SALES";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Inventory;
            lblTabTitle.Text = "INVENTORY";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Reports;
            lblTabTitle.Text = "REPORTS";
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Analytics;
            lblTabTitle.Text = "ANALYTICS";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Settings;
            lblTabTitle.Text = "SETTINGS";
        }
    }
}
