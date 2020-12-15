﻿using BoozewasherDomain.Entities;
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

namespace BoozewasherApp.Forms.VehicleForms
{
    public partial class AddVehicleForm : Form
    {
        private IVehicleRepository VehicleRepository { get; set; }
        public AddVehicleForm(IVehicleRepository vehicleRepository)
        {
            InitializeComponent();
            VehicleRepository = vehicleRepository;
        }
        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            LoadDgvVehicle();
        }

        private void btnAdd_Click(object sender, EventArgs e) => AddVehicle();

        #region Private Methods

        private void AddVehicle()
        {
            var vehicle = new Vehicle()
            {
                Type = txtboxType.Text,
                Brand = txtboxBrand.Text,
                Model = txtboxModel.Text,
                Description = txtboxDescription.Text
            };

            VehicleRepository.AddVehicle(vehicle);

            LoadDgvVehicle();
        }

        private void LoadDgvVehicle()
        {
            dgvVehicle.DataSource = VehicleRepository.GetAllVehicles();
        }

        #endregion

        
    }
}
