using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Helpers;
using BoozewasherDomain.Enums;
using BoozewasherDomain.IRepositories;
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
        public IServiceRepository ServiceRepository { get; private set; }
        public IVehicleRepository VehicleRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public MainForm(IServiceRepository serviceRepository,
                        IItemRepository itemRepository,
                        IVehicleRepository vehicleRepository,
                        ITransactionRepository transactionRepository)
        {
            InitializeComponent();

            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #region TAB CONTROL
        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Home;
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Sales;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Employees;
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
        #endregion
        #region DropDownMenu SALES
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (panelTransactions.Visible)
            {
                panelTransactions.Visible = false;
            }
            else
            {
                btnTransactions.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelItems);
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
                btnVehicles.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelItems);
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
                btnServices.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelItems);
            }
            
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (panelItems.Visible)
            {
                panelItems.Visible = false;
            }
            else
            {
                btnItems.ShowHideDropDown(panelTransactions, panelVehicles, panelServices, panelItems);
            }
            
        }
        #endregion
        public void ShowHideSalesUserControls(bool isAddItem = false, bool isDeleteItem = false, bool isUpdateItem = false, bool isViewItem = false,
                                              bool isAddService = false, bool isDeleteService = false, bool isUpdateService = false, bool isViewService = false)
        {
            addItemUserControl1.Visible = isAddItem;
            updateItemUserControl1.Visible = isUpdateItem;
            deleteItemUserControl1.Visible = isDeleteItem;

            addServiceUserControl1.Visible = isAddService;
            updateServiceUserControl1.Visible = isUpdateService;
            deleteServiceUserControl1.Visible = isDeleteService;
        }
        private void btnItemsAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addItemUserControl1.mainForm = this;
            addItemUserControl1.LoadDgvItems();
            ShowHideSalesUserControls(isAddItem: true);

            this.Cursor = Cursors.Default;
        }
        private void btnItemsUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateItemUserControl1.mainForm = this;
            updateItemUserControl1.LoadDgvItems();
            ShowHideSalesUserControls(isUpdateItem: true);

            this.Cursor = Cursors.Default;
        }


        private void btnItemsDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            deleteItemUserControl1.mainForm = this;
            deleteItemUserControl1.LoadDgvItems();
            ShowHideSalesUserControls(isDeleteItem: true);

            this.Cursor = Cursors.Default;
        }

        private void btnServicesAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addServiceUserControl1.mainForm = this;
            addServiceUserControl1.LoadDgvServices();
            ShowHideSalesUserControls(isAddService: true);

            this.Cursor = Cursors.Default;
        }

        private void btnServicesUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            ShowHideSalesUserControls(isUpdateService: true);

            this.Cursor = Cursors.Default;
        }

        private void btnServicesDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            ShowHideSalesUserControls(isDeleteService: true);

            this.Cursor = Cursors.Default;
        }
    }
}
