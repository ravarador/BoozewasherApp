
namespace BoozewasherApp.Forms.AttendanceForms
{
    partial class PresentEmployeeUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeInTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimeOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time In Time: ";
            // 
            // lblTimeInTime
            // 
            this.lblTimeInTime.AutoSize = true;
            this.lblTimeInTime.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInTime.Location = new System.Drawing.Point(84, 153);
            this.lblTimeInTime.Name = "lblTimeInTime";
            this.lblTimeInTime.Size = new System.Drawing.Size(70, 19);
            this.lblTimeInTime.TabIndex = 1;
            this.lblTimeInTime.Text = "9:30 AM";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 188);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 44);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "The Quick Brown Fox Jumps Over ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employee Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 109);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(10, 153);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 19);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id:";
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.Maroon;
            this.btnTimeOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTimeOut.FlatAppearance.BorderSize = 0;
            this.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOut.ForeColor = System.Drawing.Color.White;
            this.btnTimeOut.Location = new System.Drawing.Point(0, 235);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(171, 31);
            this.btnTimeOut.TabIndex = 7;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            // 
            // PresentEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimeInTime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PresentEmployeeUserControl";
            this.Size = new System.Drawing.Size(171, 266);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeInTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimeOut;
    }
}
