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

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class ItemLookupForm : Form
    {
        private IItemRepository ItemRepository { get; set; }
        private int SelectedItemId { get; set; }
        public ItemLookupForm(IItemRepository itemRepository)
        {
            InitializeComponent();
            ItemRepository = itemRepository;
        }

        private void ItemLookupForm_Load(object sender, EventArgs e)
        {
            LoadDgvItem();
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemId = (int)dgvItem.SelectedRows[0].Cells[0].Value;

            this.Close();
        }

        #region Private Methods
        private void LoadDgvItem()
        {
            dgvItem.DataSource = ItemRepository.GetAllItems();
        }
        #endregion
    }
}
