using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.EmployeeForms
{
    public partial class DeleteEmployeeUserControl : UserControl
    {
        public MainForm mainForm;
        private int? SelectedEmployeeId { get; set; }
        public DeleteEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void DeleteEmployeeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedEmployeeId = (int)dgvEmployees.SelectedRows[0].Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedEmployeeId != null)
            {
                DeleteEmployee();
                LoadDgvEmployees();
            }
            else
            {
                MessageBox.Show("Select an item to delete!", "Error");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        #region Private/public Methods
        private void DeleteEmployee()
        {
            mainForm.EmployeeRepository.DeleteEmployee(SelectedEmployeeId.Value);
            SelectedEmployeeId = null;
        }
        public void LoadDgvEmployees()
        {
            dgvEmployees.DataSource = mainForm.EmployeeRepository.GetEmployeesByBranchId(mainForm.UserInformation.BranchId);
        }

        #endregion

        
    }
}
