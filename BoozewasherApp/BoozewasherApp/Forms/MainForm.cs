﻿using BoozewasherApp.Helpers;
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

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            
            btnTransactions.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            
            btnVehicles.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            
            btnServices.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
        }

        private void btnViewTodaySales_Click(object sender, EventArgs e)
        {
            
            btnViewTodaySales.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelViewTodaySales);
        }
    }
}
