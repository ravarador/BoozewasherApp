namespace BoozewasherApp.Forms.TransactionForms
{
    partial class UpdateTransactionForm
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnVehicleLookup = new System.Windows.Forms.Button();
            this.btnServiceLookup = new System.Windows.Forms.Button();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxPlateNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboServiceType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datepickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxItems = new System.Windows.Forms.ListBox();
            this.btnItemLookup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTransaction.Location = new System.Drawing.Point(0, 341);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(521, 247);
            this.dgvTransaction.TabIndex = 9;
            this.dgvTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnVehicleLookup
            // 
            this.btnVehicleLookup.FlatAppearance.BorderSize = 0;
            this.btnVehicleLookup.Location = new System.Drawing.Point(375, 63);
            this.btnVehicleLookup.Name = "btnVehicleLookup";
            this.btnVehicleLookup.Size = new System.Drawing.Size(127, 23);
            this.btnVehicleLookup.TabIndex = 5;
            this.btnVehicleLookup.Text = "Vehicle Lookup";
            this.btnVehicleLookup.UseVisualStyleBackColor = true;
            this.btnVehicleLookup.Click += new System.EventHandler(this.btnVehicleLookup_Click);
            // 
            // btnServiceLookup
            // 
            this.btnServiceLookup.FlatAppearance.BorderSize = 0;
            this.btnServiceLookup.Location = new System.Drawing.Point(375, 36);
            this.btnServiceLookup.Name = "btnServiceLookup";
            this.btnServiceLookup.Size = new System.Drawing.Size(127, 23);
            this.btnServiceLookup.TabIndex = 3;
            this.btnServiceLookup.Text = "Service Lookup";
            this.btnServiceLookup.UseVisualStyleBackColor = true;
            this.btnServiceLookup.Click += new System.EventHandler(this.btnServiceLookup_Click);
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(169, 118);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(200, 20);
            this.txtboxCost.TabIndex = 7;
            // 
            // txtboxPlateNumber
            // 
            this.txtboxPlateNumber.Location = new System.Drawing.Point(169, 92);
            this.txtboxPlateNumber.Name = "txtboxPlateNumber";
            this.txtboxPlateNumber.Size = new System.Drawing.Size(200, 20);
            this.txtboxPlateNumber.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cost........................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Plate Number..........";
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Location = new System.Drawing.Point(169, 65);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(200, 21);
            this.comboVehicleType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Vehicle Id..........";
            // 
            // comboServiceType
            // 
            this.comboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServiceType.FormattingEnabled = true;
            this.comboServiceType.Location = new System.Drawing.Point(169, 38);
            this.comboServiceType.Name = "comboServiceType";
            this.comboServiceType.Size = new System.Drawing.Size(200, 21);
            this.comboServiceType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Service Id..........";
            // 
            // datepickerDateTime
            // 
            this.datepickerDateTime.Location = new System.Drawing.Point(169, 12);
            this.datepickerDateTime.Name = "datepickerDateTime";
            this.datepickerDateTime.Size = new System.Drawing.Size(200, 20);
            this.datepickerDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date and Time........";
            // 
            // listboxItems
            // 
            this.listboxItems.FormattingEnabled = true;
            this.listboxItems.Location = new System.Drawing.Point(169, 144);
            this.listboxItems.Name = "listboxItems";
            this.listboxItems.Size = new System.Drawing.Size(200, 160);
            this.listboxItems.TabIndex = 24;
            // 
            // btnItemLookup
            // 
            this.btnItemLookup.FlatAppearance.BorderSize = 0;
            this.btnItemLookup.Location = new System.Drawing.Point(375, 144);
            this.btnItemLookup.Name = "btnItemLookup";
            this.btnItemLookup.Size = new System.Drawing.Size(127, 23);
            this.btnItemLookup.TabIndex = 23;
            this.btnItemLookup.Text = "Item Lookup";
            this.btnItemLookup.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Item List..........";
            // 
            // UpdateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 588);
            this.Controls.Add(this.listboxItems);
            this.Controls.Add(this.btnItemLookup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "UpdateTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Transaction";
            this.Load += new System.EventHandler(this.UpdateTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnVehicleLookup;
        private System.Windows.Forms.Button btnServiceLookup;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxPlateNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboServiceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepickerDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxItems;
        private System.Windows.Forms.Button btnItemLookup;
        private System.Windows.Forms.Label label6;
    }
}