
namespace BoozewasherApp.Forms.TransactionForms
{
    partial class AddTransactionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVehicleLookup = new System.Windows.Forms.Button();
            this.btnServiceLookup = new System.Windows.Forms.Button();
            this.btnItemLookup = new System.Windows.Forms.Button();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.numericCost = new System.Windows.Forms.NumericUpDown();
            this.txtboxPlateNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxVehicle = new System.Windows.Forms.TextBox();
            this.lblIsEmpty = new System.Windows.Forms.Label();
            this.txtboxService = new System.Windows.Forms.TextBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(445, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 25);
            this.label15.TabIndex = 46;
            this.label15.Text = "Add Transaction";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.btnVehicleLookup);
            this.panel7.Controls.Add(this.btnServiceLookup);
            this.panel7.Controls.Add(this.btnItemLookup);
            this.panel7.Controls.Add(this.dgvItemsList);
            this.panel7.Controls.Add(this.numericCost);
            this.panel7.Controls.Add(this.txtboxPlateNumber);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtboxVehicle);
            this.panel7.Controls.Add(this.lblIsEmpty);
            this.panel7.Controls.Add(this.txtboxService);
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(983, 214);
            this.panel7.TabIndex = 45;
            // 
            // btnVehicleLookup
            // 
            this.btnVehicleLookup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVehicleLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehicleLookup.FlatAppearance.BorderSize = 0;
            this.btnVehicleLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleLookup.Font = new System.Drawing.Font("Gadugi", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleLookup.ForeColor = System.Drawing.Color.White;
            this.btnVehicleLookup.Location = new System.Drawing.Point(590, 69);
            this.btnVehicleLookup.Name = "btnVehicleLookup";
            this.btnVehicleLookup.Size = new System.Drawing.Size(83, 23);
            this.btnVehicleLookup.TabIndex = 9;
            this.btnVehicleLookup.Text = "Vehicle Lookup";
            this.btnVehicleLookup.UseVisualStyleBackColor = false;
            this.btnVehicleLookup.Click += new System.EventHandler(this.btnVehicleLookup_Click);
            // 
            // btnServiceLookup
            // 
            this.btnServiceLookup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServiceLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServiceLookup.FlatAppearance.BorderSize = 0;
            this.btnServiceLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceLookup.Font = new System.Drawing.Font("Gadugi", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceLookup.ForeColor = System.Drawing.Color.White;
            this.btnServiceLookup.Location = new System.Drawing.Point(590, 45);
            this.btnServiceLookup.Name = "btnServiceLookup";
            this.btnServiceLookup.Size = new System.Drawing.Size(83, 23);
            this.btnServiceLookup.TabIndex = 7;
            this.btnServiceLookup.Text = "Service Lookup";
            this.btnServiceLookup.UseVisualStyleBackColor = false;
            this.btnServiceLookup.Click += new System.EventHandler(this.btnServiceLookup_Click);
            // 
            // btnItemLookup
            // 
            this.btnItemLookup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnItemLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItemLookup.FlatAppearance.BorderSize = 0;
            this.btnItemLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemLookup.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemLookup.ForeColor = System.Drawing.Color.White;
            this.btnItemLookup.Location = new System.Drawing.Point(839, 147);
            this.btnItemLookup.Name = "btnItemLookup";
            this.btnItemLookup.Size = new System.Drawing.Size(100, 23);
            this.btnItemLookup.TabIndex = 12;
            this.btnItemLookup.Text = "Item Lookup";
            this.btnItemLookup.UseVisualStyleBackColor = false;
            this.btnItemLookup.Click += new System.EventHandler(this.btnItemLookup_Click);
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AllowUserToResizeColumns = false;
            this.dgvItemsList.AllowUserToResizeRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvItemsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Location = new System.Drawing.Point(699, 43);
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItemsList.Size = new System.Drawing.Size(240, 98);
            this.dgvItemsList.TabIndex = 42;
            // 
            // numericCost
            // 
            this.numericCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericCost.DecimalPlaces = 2;
            this.numericCost.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCost.Location = new System.Drawing.Point(398, 120);
            this.numericCost.Name = "numericCost";
            this.numericCost.Size = new System.Drawing.Size(275, 21);
            this.numericCost.TabIndex = 11;
            // 
            // txtboxPlateNumber
            // 
            this.txtboxPlateNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPlateNumber.BackColor = System.Drawing.Color.White;
            this.txtboxPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPlateNumber.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPlateNumber.Location = new System.Drawing.Point(398, 96);
            this.txtboxPlateNumber.Name = "txtboxPlateNumber";
            this.txtboxPlateNumber.Size = new System.Drawing.Size(275, 18);
            this.txtboxPlateNumber.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 25);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 6, 14, 37, 33, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(573, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(696, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Items List";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(299, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Date and Time";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Service";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cost";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(343, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Vehicle";
            // 
            // txtboxVehicle
            // 
            this.txtboxVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxVehicle.BackColor = System.Drawing.Color.White;
            this.txtboxVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxVehicle.Enabled = false;
            this.txtboxVehicle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxVehicle.Location = new System.Drawing.Point(398, 72);
            this.txtboxVehicle.Name = "txtboxVehicle";
            this.txtboxVehicle.Size = new System.Drawing.Size(186, 18);
            this.txtboxVehicle.TabIndex = 8;
            // 
            // lblIsEmpty
            // 
            this.lblIsEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsEmpty.AutoSize = true;
            this.lblIsEmpty.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsEmpty.Location = new System.Drawing.Point(304, 96);
            this.lblIsEmpty.Name = "lblIsEmpty";
            this.lblIsEmpty.Size = new System.Drawing.Size(88, 16);
            this.lblIsEmpty.TabIndex = 33;
            this.lblIsEmpty.Text = "Plate Number";
            // 
            // txtboxService
            // 
            this.txtboxService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxService.BackColor = System.Drawing.Color.White;
            this.txtboxService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxService.Enabled = false;
            this.txtboxService.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxService.Location = new System.Drawing.Point(398, 48);
            this.txtboxService.Name = "txtboxService";
            this.txtboxService.Size = new System.Drawing.Size(186, 18);
            this.txtboxService.TabIndex = 6;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 248);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(983, 294);
            this.dgvTransactions.TabIndex = 14;
            // 
            // AddTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "AddTransactionUserControl";
            this.Size = new System.Drawing.Size(983, 542);
            this.Load += new System.EventHandler(this.AddTransactionUserControl_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxVehicle;
        private System.Windows.Forms.Label lblIsEmpty;
        private System.Windows.Forms.TextBox txtboxService;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.NumericUpDown numericCost;
        private System.Windows.Forms.TextBox txtboxPlateNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVehicleLookup;
        private System.Windows.Forms.Button btnServiceLookup;
        private System.Windows.Forms.Button btnItemLookup;
        private System.Windows.Forms.DataGridView dgvItemsList;
    }
}
