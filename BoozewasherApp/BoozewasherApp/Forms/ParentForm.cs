﻿using BoozewasherApp.Forms.ItemForms;
using BoozewasherApp.Forms.ServiceForms;
using BoozewasherApp.Forms.SummaryForms;
using BoozewasherApp.Forms.TransactionForms;
using BoozewasherApp.Forms.VehicleForms;
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

namespace BoozewasherApp
{
    public partial class ParentForm : Form
    {
        public IServiceRepository ServiceRepository { get; private set; }
        public IVehicleRepository VehicleRepository { get; private set; }
        public ITransactionRepository TransactionRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public ParentForm(IServiceRepository serviceRepository,
                          IItemRepository itemRepository,
                          IVehicleRepository vehicleRepository,
                          ITransactionRepository transactionRepository)
        {
            InitializeComponent();

            ServiceRepository = serviceRepository;
            VehicleRepository = vehicleRepository;
            TransactionRepository = transactionRepository;
            ItemRepository = itemRepository;
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm(ServiceRepository);

            addServiceForm.Show();
            addServiceForm.MdiParent = this;
        }

        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateServiceForm updateServiceForm = new UpdateServiceForm(ServiceRepository);

            updateServiceForm.Show();
            updateServiceForm.MdiParent = this;
        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteServiceForm deleteServiceForm = new DeleteServiceForm(ServiceRepository);

            deleteServiceForm.Show();
            deleteServiceForm.MdiParent = this;
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm(VehicleRepository);

            addVehicleForm.Show();
            addVehicleForm.MdiParent = this;
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVehicleForm deleteVehicleForm = new DeleteVehicleForm(VehicleRepository);

            deleteVehicleForm.Show();
            deleteVehicleForm.MdiParent = this;
        }

        private void updateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicleForm updateVehicleForm = new UpdateVehicleForm(VehicleRepository);

            updateVehicleForm.Show();
            updateVehicleForm.MdiParent = this;
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransactionForm = new AddTransactionForm(ServiceRepository, 
                                                                           VehicleRepository, 
                                                                           TransactionRepository);

            addTransactionForm.Show();
            addTransactionForm.MdiParent = this;
        }

        private void updateTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTransactionForm updateTransactionForm = new UpdateTransactionForm(ServiceRepository, 
                                                                                    VehicleRepository, 
                                                                                    TransactionRepository);

            updateTransactionForm.Show();
            updateTransactionForm.MdiParent = this;
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTransactionForm deleteTransactionForm = new DeleteTransactionForm(TransactionRepository);

            deleteTransactionForm.Show();
            deleteTransactionForm.MdiParent = this;
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryReportSelector summaryReportSelector = new SummaryReportSelector(TransactionRepository);

            summaryReportSelector.Show();
            summaryReportSelector.MdiParent = this;
        }

        private void generateChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryChart summaryChartReportSelector = new SummaryChart(TransactionRepository);

            summaryChartReportSelector.Show();
            summaryChartReportSelector.MdiParent = this;
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(ItemRepository);

            addItemForm.Show();
            addItemForm.MdiParent = this;
        }

        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItemForm updateItemForm = new UpdateItemForm(ItemRepository);

            updateItemForm.Show();
            updateItemForm.MdiParent = this;
        }
    }
}
