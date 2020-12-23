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
using BoozewasherDomain.IRepositories;

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class AddItemForm : Form
    {
        private IItemRepository ItemRepository { get; set; }
        public AddItemForm(IItemRepository itemRepository)
        {
            InitializeComponent();
            ItemRepository = itemRepository;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            LoadDgvItem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        #region Private Methods

        private void AddItem()
        {
            
            var item = new Item()
            {
                Name = txtboxName.Text,
                Description = txtboxDescription.Text,
                Barcode = txtboxBarcode.Text,
                IsEmpty = bool.Parse(comboIsEmpty.SelectedItem.ToString()),
                UsageCount = int.Parse(txtboxUsageCount.Text),
                Expense = decimal.Parse(txtboxExpense.Text),
                
            };

            ItemRepository.AddItem(item);

            LoadDgvItem();
        }

        private void LoadDgvItem()
        {
            dgvItem.DataSource = ItemRepository.GetAllItems();
        }

        #endregion
    }
}
