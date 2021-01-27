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
    public partial class AddEmployeeUserControl : UserControl
    {
        public MainForm mainForm { get; set; }
        public AddEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void AddEmployeeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        #region Private/public Methods
        private void AddEmployee()
        {
            var employee = new Employee()
            {
                FirstName = txtboxFirstName.Text,
                MiddleName = txtboxMiddleName.Text,
                LastName = txtboxLastName.Text,
                Address = txtboxAddress.Text,
                Birthdate = datePickerBirthdate.Value.ToShortDateString(),
                TIN = txtboxTIN.Text,
                Email = txtboxEmail.Text,
                ContactNo = txtboxContactNumber.Text
            };

            EmployeeValidator validator = new EmployeeValidator();
            ValidationResult result = validator.Validate(employee);

            if (result.IsValid)
            {
                mainForm.EmployeeRepository.AddEmployee(employee);
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
