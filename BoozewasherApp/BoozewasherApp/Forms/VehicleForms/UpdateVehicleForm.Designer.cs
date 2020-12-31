namespace BoozewasherApp.Forms.VehicleForms
{
    partial class UpdateVehicleForm
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
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxBrand = new System.Windows.Forms.TextBox();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.AllowUserToResizeColumns = false;
            this.dgvVehicle.AllowUserToResizeRows = false;
            this.dgvVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVehicle.Location = new System.Drawing.Point(0, 191);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(472, 259);
            this.dgvVehicle.TabIndex = 6;
            this.dgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellClick);
            // 
            // txtboxType
            // 
            this.txtboxType.Location = new System.Drawing.Point(137, 33);
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(275, 20);
            this.txtboxType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Type...................";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(137, 111);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 20);
            this.txtboxDescription.TabIndex = 4;
            // 
            // txtboxBrand
            // 
            this.txtboxBrand.Location = new System.Drawing.Point(137, 59);
            this.txtboxBrand.Name = "txtboxBrand";
            this.txtboxBrand.Size = new System.Drawing.Size(275, 20);
            this.txtboxBrand.TabIndex = 2;
            // 
            // txtboxModel
            // 
            this.txtboxModel.Location = new System.Drawing.Point(137, 85);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(275, 20);
            this.txtboxModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Model................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Brand...................";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(312, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.txtboxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxBrand);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Vehicle";
            this.Load += new System.EventHandler(this.UpdateVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.TextBox txtboxBrand;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}