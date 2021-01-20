using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoozewasherDomain.Entities;
using FluentValidation.Results;

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class UpdateItemUserControl : UserControl
    {
        private int? SelectedItemId { get; set; }
        public MainForm mainForm;
        public UpdateItemUserControl()
        {
            InitializeComponent();
        }

        private void UpdateItemUserControl_Load(object sender, EventArgs e)
        {
            //LoadDgvItems();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedItemId != null)
            {
                UpdateItem();
                LoadDgvItems();
            }
            else
            {
                MessageBox.Show("Select an item to update!", "Error");
            }
            
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemId = (int)dgvItems.SelectedRows[0].Cells[0].Value;

            txtboxName.Text = dgvItems.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvItems.SelectedRows[0].Cells[2].Value.ToString();
            txtboxBarcode.Text = dgvItems.SelectedRows[0].Cells[3].Value.ToString();
            comboIsEmpty.SelectedItem = dgvItems.SelectedRows[0].Cells[4].Value.ToString();
            txtboxUsageCount.Text = dgvItems.SelectedRows[0].Cells[5].Value.ToString();
            txtboxExpense.Text = dgvItems.SelectedRows[0].Cells[6].Value.ToString();
        }
        #region Private/public Methods
        private void UpdateItem()
        {
            var item = new Item()
            {
                Id = SelectedItemId.Value,
                Name = txtboxName.Text,
                Description = txtboxDescription.Text,
                Barcode = txtboxBarcode.Text,
                IsEmpty = bool.Parse(comboIsEmpty.SelectedItem.ToString()),
                UsageCount = int.Parse(txtboxUsageCount.Text),
                Expense = decimal.Parse(txtboxExpense.Text),
                BranchId = 1

            };

            ItemValidator validator = new ItemValidator();
            ValidationResult result = validator.Validate(item);

            if (result.IsValid)
            {
                mainForm.ItemRepository.UpdateItem(item);
                ResetFields();
            }
            else
            {
                MessageBox.Show(result.ToString());
            }
            
        }
        public void ResetFields()
        {
            txtboxName.Text = string.Empty;
            txtboxDescription.Text = string.Empty;
            txtboxBarcode.Text = string.Empty;
            comboIsEmpty.SelectedItem = "False";
            txtboxUsageCount.Text = "0";
            txtboxExpense.Text = "0";
        }
        public void LoadDgvItems()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
        }
        #endregion
    }
}
