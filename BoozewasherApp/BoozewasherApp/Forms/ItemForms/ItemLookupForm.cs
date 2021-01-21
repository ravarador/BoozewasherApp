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
using BoozewasherDomain.Entities;

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class ItemLookupForm : Form
    {
        private MainForm mainForm { get; set; }
        public int SelectedItemIdForLookup { get; set; }
        public Item SelectedItem { get; set; }
        public ItemLookupForm(MainForm MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;

        }

        private void ItemLookupForm_Load(object sender, EventArgs e)
        {
            LoadDgvItem();
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemIdForLookup = (int)dgvItem.SelectedRows[0].Cells[0].Value;


            SelectedItem = new Item
            {
                Id = (int)dgvItem.SelectedRows[0].Cells[0].Value,
                Name = dgvItem.SelectedRows[0].Cells[1].Value.ToString(),
                Description = dgvItem.SelectedRows[0].Cells[2].Value.ToString(),
                Barcode = dgvItem.SelectedRows[0].Cells[3].Value.ToString(),
                IsEmpty = (bool)dgvItem.SelectedRows[0].Cells[4].Value,
                UsageCount = (int)dgvItem.SelectedRows[0].Cells[5].Value,
                Expense = (decimal)dgvItem.SelectedRows[0].Cells[6].Value
            };

            this.Close();
        }

        #region Private Methods
        private void LoadDgvItem()
        {
            dgvItem.DataSource = mainForm.ItemRepository.GetItemsByBranchId(mainForm.UserInformation.BranchId);
        }
        #endregion
    }
}
