using BoozewasherApp.Helpers;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Home;
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Sales;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Inventory;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Reports;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Analytics;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Settings;
        }
        #region DropDownMenu SALES
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (panelTransactions.Visible)
            {
                panelTransactions.Visible = false;
            }
            else
            {
                btnTransactions.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
            }
            
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            if (panelVehicles.Visible)
            {
                panelVehicles.Visible = false;
            }
            else
            {
                btnVehicles.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
            }
            
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            if (panelServices.Visible)
            {
                panelServices.Visible = false;
            }
            else
            {
                btnServices.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
            }
            
        }

        private void btnViewTodaySales_Click(object sender, EventArgs e)
        {
            if (panelViewTodaySales.Visible)
            {
                panelViewTodaySales.Visible = false;
            }
            else
            {
                btnViewTodaySales.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
            }
            
        }
        #endregion
    }
}
