using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Forms.SummaryForms;
using BoozewasherApp.Helpers;
using BoozewasherDomain.Dtos;
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
        public LoginForm LoginForm { get; set; }
        public UserInformationDto  UserInformation { get; private set; }
        public IServiceRepository ServiceRepository { get; private set; }
        public IVehicleRepository VehicleRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IAttendanceRepository AttendanceRepository { get; private set; }
        public MainForm(UserInformationDto userInformation,
                        IServiceRepository serviceRepository,
                        IItemRepository itemRepository,
                        IVehicleRepository vehicleRepository,
                        ITransactionRepository transactionRepository,
                        IEmployeeRepository employeeRepository,
                        IAttendanceRepository attendanceRepository)
        {
            InitializeComponent();
            UserInformation = userInformation;
            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
            EmployeeRepository = employeeRepository;
            AttendanceRepository = attendanceRepository;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserInformation.Text = $"User: {UserInformation.FirstName} {UserInformation.LastName} | Logged In DateTime: {DateTime.Now.ToShortDateString()} | Branch ID: {UserInformation.BranchId}";
        }
        #region TAB CONTROL
        private void btnHome_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = (int)TabControlEnums.Home;
        private void btnSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Sales;
            ShowHideSalesUserControls();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (int)TabControlEnums.Employees;
            employeeHomeUserControl1.mainForm = this;
            employeeHomeUserControl1.LoadPresentEmployeeFlowLayoutPanel();
            ShowHideEmployeeUserControls(isHomeEmployee: true);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var summary = new SummaryReportSelector();
            summary.mainForm = this;
            summary.ShowDialog();
            //tabControl1.SelectedIndex = (int)TabControlEnums.Reports;
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            analyticsUserControl1.mainForm = this;
            analyticsUserControl1.DrawGraphAllData();
            tabControl1.SelectedIndex = (int)TabControlEnums.Analytics;
        }

        private void btnSettings_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = (int)TabControlEnums.Settings;
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
                                              bool isAddService = false, bool isDeleteService = false, bool isUpdateService = false, bool isViewService = false,
                                              bool isAddVehicle = false, bool isDeleteVehicle = false, bool isUpdateVehicle = false, bool isViewVehicle = false,
                                              bool isAddTransaction = false, bool isDeleteTransaction = false, bool isUpdateTransaction = false, bool isViewTransaction = false)
        {
            addItemUserControl1.Visible = isAddItem;
            updateItemUserControl1.Visible = isUpdateItem;
            deleteItemUserControl1.Visible = isDeleteItem;

            addServiceUserControl1.Visible = isAddService;
            updateServiceUserControl1.Visible = isUpdateService;
            deleteServiceUserControl1.Visible = isDeleteService;
            
            addVehicleUserControl1.Visible = isAddVehicle;
            updateVehicleUserControl1.Visible = isUpdateVehicle;
            deleteVehicleUserControl1.Visible = isDeleteVehicle;

            addTransactionUserControl1.Visible = isAddTransaction;
            updateTransactionUserControl1.Visible = isUpdateTransaction;
            deleteTransactionUserControl1.Visible = isDeleteTransaction;
        }
        public void ShowHideEmployeeUserControls(bool isAddEmployee = false, bool isDeleteEmployee = false, bool isUpdateEmployee = false, bool isViewEmployee = false, bool isHomeEmployee = false)
        {
            addEmployeeUserControl1.Visible = isAddEmployee;
            updateEmployeeUserControl1.Visible = isUpdateEmployee;
            deleteEmployeeUserControl1.Visible = isDeleteEmployee;
            employeeHomeUserControl1.Visible = isHomeEmployee;
        }
        private void btnItemsAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addItemUserControl1.mainForm = this;
            addItemUserControl1.ResetFields();
            addItemUserControl1.LoadDgvItems();
            ShowHideSalesUserControls(isAddItem: true);

            this.Cursor = Cursors.Default;
        }
        private void btnItemsUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateItemUserControl1.mainForm = this;
            updateItemUserControl1.ResetFields();
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
            addServiceUserControl1.ResetFields();
            addServiceUserControl1.LoadDgvServices();
            ShowHideSalesUserControls(isAddService: true);

            this.Cursor = Cursors.Default;
        }

        private void btnServicesUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateServiceUserControl1.mainForm = this;
            updateServiceUserControl1.ResetFields();
            updateServiceUserControl1.LoadDgvServices();
            ShowHideSalesUserControls(isUpdateService: true);

            this.Cursor = Cursors.Default;
        }

        private void btnServicesDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            deleteServiceUserControl1.mainForm = this;
            deleteServiceUserControl1.LoadDgvServices();
            ShowHideSalesUserControls(isDeleteService: true);

            this.Cursor = Cursors.Default;
        }

        private void btnVehiclesAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addVehicleUserControl1.mainForm = this;
            addVehicleUserControl1.ResetFields();
            addVehicleUserControl1.LoadDgvVehicles();
            ShowHideSalesUserControls(isAddVehicle: true);

            this.Cursor = Cursors.Default;
        }

        private void btnVehiclesUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateVehicleUserControl1.mainForm = this;
            updateItemUserControl1.ResetFields();
            updateVehicleUserControl1.LoadDgvVehicles();
            ShowHideSalesUserControls(isUpdateVehicle: true);

            this.Cursor = Cursors.Default;
        }

        private void btnVehiclesDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            deleteVehicleUserControl1.mainForm = this;
            deleteVehicleUserControl1.LoadDgvVehicles();
            ShowHideSalesUserControls(isDeleteVehicle: true);

            this.Cursor = Cursors.Default;
        }

        private void btnTransactionsAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addTransactionUserControl1.mainForm = this;
            addTransactionUserControl1.ResetFields();
            addTransactionUserControl1.SetColumnsOfItemDgv();
            addTransactionUserControl1.LoadDgvTransactions();
            ShowHideSalesUserControls(isAddTransaction: true);

            this.Cursor = Cursors.Default;
        }

        private void btnTransactionsUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateTransactionUserControl1.mainForm = this;
            updateTransactionUserControl1.ResetFields();
            updateTransactionUserControl1.SetColumnsOfItemDgv();
            updateTransactionUserControl1.LoadDgvTransactions();
            ShowHideSalesUserControls(isUpdateTransaction: true);

            this.Cursor = Cursors.Default;
        }

        private void btnTransactionsDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            deleteTransactionUserControl1.mainForm = this;
            deleteTransactionUserControl1.LoadDgvTransactions();
            ShowHideSalesUserControls(isDeleteTransaction: true);

            this.Cursor = Cursors.Default;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            addEmployeeUserControl1.mainForm = this;
            addEmployeeUserControl1.ResetFields();
            addEmployeeUserControl1.LoadDgvEmployees();
            ShowHideEmployeeUserControls(isAddEmployee: true);

            this.Cursor = Cursors.Default;
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            updateEmployeeUserControl1.mainForm = this;
            updateEmployeeUserControl1.ResetFields();
            updateEmployeeUserControl1.LoadDgvEmployees();
            ShowHideEmployeeUserControls(isUpdateEmployee: true);

            this.Cursor = Cursors.Default;
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            deleteEmployeeUserControl1.mainForm = this;
            deleteEmployeeUserControl1.LoadDgvEmployees();
            ShowHideEmployeeUserControls(isDeleteEmployee: true);

            this.Cursor = Cursors.Default;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.ResetFields();
            LoginForm.Show();
        }

        
    }
}
