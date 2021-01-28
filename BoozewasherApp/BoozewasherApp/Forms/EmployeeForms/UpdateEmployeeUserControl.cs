using BoozewasherDomain.Entities;
using FluentValidation.Results;
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
    public partial class UpdateEmployeeUserControl : UserControl
    {
        private int? SelectedEmployeeId { get; set; }
        public MainForm mainForm { get; set; }
        public UpdateEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void UpdateEmployeeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedEmployeeId != null)
            {
                UpdateEmployee();
                LoadDgvEmployees();
            }
            else
            {
                MessageBox.Show("Select an employee to update!", "Error");
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedEmployeeId = (int)dgvEmployees.SelectedRows[0].Cells[0].Value;

            txtboxFirstName.Text = dgvEmployees.SelectedRows[0].Cells[1].Value.ToString();
            txtboxMiddleName.Text = dgvEmployees.SelectedRows[0].Cells[2].Value.ToString();
            txtboxLastName.Text = dgvEmployees.SelectedRows[0].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvEmployees.SelectedRows[0].Cells[4].Value.ToString();
            datePickerBirthdate.Value = DateTime.Parse(dgvEmployees.SelectedRows[0].Cells[5].Value.ToString()).Date;
            txtboxTIN.Text = dgvEmployees.SelectedRows[0].Cells[6].Value.ToString();
            txtboxEmail.Text = dgvEmployees.SelectedRows[0].Cells[7].Value.ToString();
            txtboxContactNumber.Text = dgvEmployees.SelectedRows[0].Cells[8].Value.ToString();
        }
        #region Private/public Methods
        private void UpdateEmployee()
        {
            var employee = new Employee()
            {
                Id = SelectedEmployeeId.Value,
                FirstName = txtboxFirstName.Text,
                MiddleName = txtboxMiddleName.Text,
                LastName = txtboxLastName.Text,
                Address = txtboxAddress.Text,
                Birthdate = datePickerBirthdate.Value.ToShortDateString(),
                TIN = txtboxTIN.Text,
                Email = txtboxEmail.Text,
                ContactNo = txtboxContactNumber.Text,
                BranchId = mainForm.UserInformation.BranchId
            };

            EmployeeValidator validator = new EmployeeValidator();
            ValidationResult result = validator.Validate(employee);

            if (result.IsValid)
            {
                mainForm.EmployeeRepository.UpdateEmployee(employee);
                ResetFields();
            }
            else
            {
                MessageBox.Show(result.ToString());
            }

        }
        public void ResetFields()
        {
            txtboxFirstName.Text = string.Empty;
            txtboxMiddleName.Text = string.Empty;
            txtboxLastName.Text = string.Empty;
            txtboxAddress.Text = string.Empty;
            datePickerBirthdate.Value = DateTime.Now;
            txtboxTIN.Text = string.Empty;
            txtboxEmail.Text = string.Empty;
            txtboxContactNumber.Text = string.Empty;
        }
        public void LoadDgvEmployees()
        {
            dgvEmployees.DataSource = mainForm.EmployeeRepository.GetEmployeesByBranchId(mainForm.UserInformation.BranchId);
        }
        #endregion
    }
}
