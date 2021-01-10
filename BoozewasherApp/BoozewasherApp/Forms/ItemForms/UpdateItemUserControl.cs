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

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class UpdateItemUserControl : UserControl
    {
        private int SelectedItemId { get; set; }
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
            UpdateItem();
            LoadDgvItems();
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
                Id = SelectedItemId,
                Name = txtboxName.Text,
                Description = txtboxDescription.Text,
                Barcode = txtboxBarcode.Text,
                IsEmpty = bool.Parse(comboIsEmpty.SelectedItem.ToString()),
                UsageCount = int.Parse(txtboxUsageCount.Text),
                Expense = decimal.Parse(txtboxExpense.Text),

            };

            mainForm.ItemRepository.UpdateItem(item);
        }
        public void LoadDgvItems()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
        }
        #endregion
    }
}
