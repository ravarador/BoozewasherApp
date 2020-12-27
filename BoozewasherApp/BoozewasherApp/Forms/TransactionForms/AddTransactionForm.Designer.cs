namespace BoozewasherApp.Forms.TransactionForms
{
    partial class AddTransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboServiceType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxPlateNumber = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.btnServiceLookup = new System.Windows.Forms.Button();
            this.btnVehicleLookup = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.btnItemLookup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listboxItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date and Time........";
            // 
            // datepickerDateTime
            // 
            this.datepickerDateTime.Enabled = false;
            this.datepickerDateTime.Location = new System.Drawing.Point(169, 24);
            this.datepickerDateTime.Name = "datepickerDateTime";
            this.datepickerDateTime.Size = new System.Drawing.Size(200, 20);
            this.datepickerDateTime.TabIndex = 1;
            this.datepickerDateTime.Value = new System.DateTime(2020, 12, 10, 11, 3, 52, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Id..........";
            // 
            // comboServiceType
            // 
            this.comboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServiceType.FormattingEnabled = true;
            this.comboServiceType.Location = new System.Drawing.Point(169, 50);
            this.comboServiceType.Name = "comboServiceType";
            this.comboServiceType.Size = new System.Drawing.Size(200, 21);
            this.comboServiceType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehicle Id..........";
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Location = new System.Drawing.Point(169, 77);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(200, 21);
            this.comboVehicleType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plate Number..........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cost........................";
            // 
            // txtboxPlateNumber
            // 
            this.txtboxPlateNumber.Location = new System.Drawing.Point(169, 104);
            this.txtboxPlateNumber.Name = "txtboxPlateNumber";
            this.txtboxPlateNumber.Size = new System.Drawing.Size(200, 20);
            this.txtboxPlateNumber.TabIndex = 6;
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(169, 130);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(200, 20);
            this.txtboxCost.TabIndex = 7;
            // 
            // btnServiceLookup
            // 
            this.btnServiceLookup.FlatAppearance.BorderSize = 0;
            this.btnServiceLookup.Location = new System.Drawing.Point(375, 48);
            this.btnServiceLookup.Name = "btnServiceLookup";
            this.btnServiceLookup.Size = new System.Drawing.Size(127, 23);
            this.btnServiceLookup.TabIndex = 3;
            this.btnServiceLookup.Text = "Service Lookup";
            this.btnServiceLookup.UseVisualStyleBackColor = true;
            this.btnServiceLookup.Click += new System.EventHandler(this.btnServiceLookup_Click);
            // 
            // btnVehicleLookup
            // 
            this.btnVehicleLookup.FlatAppearance.BorderSize = 0;
            this.btnVehicleLookup.Location = new System.Drawing.Point(375, 75);
            this.btnVehicleLookup.Name = "btnVehicleLookup";
            this.btnVehicleLookup.Size = new System.Drawing.Size(127, 23);
            this.btnVehicleLookup.TabIndex = 5;
            this.btnVehicleLookup.Text = "Vehicle Lookup";
            this.btnVehicleLookup.UseVisualStyleBackColor = true;
            this.btnVehicleLookup.Click += new System.EventHandler(this.btnVehicleLookup_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransaction.Location = new System.Drawing.Point(0, 351);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(533, 241);
            this.dgvTransaction.TabIndex = 9;
            // 
            // btnItemLookup
            // 
            this.btnItemLookup.FlatAppearance.BorderSize = 0;
            this.btnItemLookup.Location = new System.Drawing.Point(375, 159);
            this.btnItemLookup.Name = "btnItemLookup";
            this.btnItemLookup.Size = new System.Drawing.Size(127, 23);
            this.btnItemLookup.TabIndex = 12;
            this.btnItemLookup.Text = "Item Lookup";
            this.btnItemLookup.UseVisualStyleBackColor = true;
            this.btnItemLookup.Click += new System.EventHandler(this.btnItemLookup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Item List..........";
            // 
            // listboxItems
            // 
            this.listboxItems.FormattingEnabled = true;
            this.listboxItems.Location = new System.Drawing.Point(169, 159);
            this.listboxItems.Name = "listboxItems";
            this.listboxItems.Size = new System.Drawing.Size(200, 160);
            this.listboxItems.TabIndex = 13;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 592);
            this.Controls.Add(this.listboxItems);
            this.Controls.Add(this.btnItemLookup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVehicleLookup);
            this.Controls.Add(this.btnServiceLookup);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxPlateNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboVehicleType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboServiceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepickerDateTime);
            this.Controls.Add(this.label1);
            this.Name = "AddTransactionForm";
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepickerDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboServiceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxPlateNumber;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.Button btnServiceLookup;
        private System.Windows.Forms.Button btnVehicleLookup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnItemLookup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listboxItems;
    }
}