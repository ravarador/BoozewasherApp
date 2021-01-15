﻿using System;
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
    public partial class AddItemUserControl : UserControl
    {
        public MainForm mainForm { get; set; }
        public AddItemUserControl()
        {
            InitializeComponent();
        }

        private void AddItemUserControl_Load(object sender, EventArgs e)
        {
            //LoadDgvItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
            LoadDgvItems();
        }

        #region Private/public Methods
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

            ItemValidator validator = new ItemValidator();
            ValidationResult result = validator.Validate(item);

            if (result.IsValid)
            {
                mainForm.ItemRepository.AddItem(item);
            }
            else
            {
                MessageBox.Show(result.ToString());
            }
            
        }

        public void LoadDgvItems()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
            comboIsEmpty.SelectedItem = "False";
        }

        #endregion
    }
}
