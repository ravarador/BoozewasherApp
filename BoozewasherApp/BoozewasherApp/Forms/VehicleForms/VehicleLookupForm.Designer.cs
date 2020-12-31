namespace BoozewasherApp.Forms.VehicleForms
{
    partial class VehicleLookupForm
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
            this.dgvVehicle.Location = new System.Drawing.Point(0, 93);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(530, 535);
            this.dgvVehicle.TabIndex = 1;
            this.dgvVehicle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellDoubleClick);
            // 
            // VehicleLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 628);
            this.Controls.Add(this.dgvVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VehicleLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Lookup";
            this.Load += new System.EventHandler(this.VehicleLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicle;
    }
}