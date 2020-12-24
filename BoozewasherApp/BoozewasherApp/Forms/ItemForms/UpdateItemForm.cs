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
    public partial class UpdateItemForm : Form
    {
        private IItemRepository ItemRepository { get; set; }
        private int SelectedItemId { get; set; }
        public UpdateItemForm(IItemRepository itemRepository)
        {
            InitializeComponent();
            ItemRepository = itemRepository;
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            LoadDgvItem();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            ItemRepository.UpdateItem(item);

            LoadDgvItem();
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemId = (int)dgvItem.SelectedRows[0].Cells[0].Value;

            txtboxName.Text = dgvItem.SelectedRows[0].Cells[1].Value.ToString();
            txtboxDescription.Text = dgvItem.SelectedRows[0].Cells[2].Value.ToString();
            txtboxBarcode.Text = dgvItem.SelectedRows[0].Cells[3].Value.ToString();
            comboIsEmpty.SelectedItem = dgvItem.SelectedRows[0].Cells[4].Value.ToString();
            txtboxUsageCount.Text = dgvItem.SelectedRows[0].Cells[5].Value.ToString();
            txtboxExpense.Text = dgvItem.SelectedRows[0].Cells[6].Value.ToString();
        }

        #region Private Methods
        private void LoadDgvItem()
        {
            dgvItem.DataSource = ItemRepository.GetAllItems();
        }
        #endregion

        
    }
}
