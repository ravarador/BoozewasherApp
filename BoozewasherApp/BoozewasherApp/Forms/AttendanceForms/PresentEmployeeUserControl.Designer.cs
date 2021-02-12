
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
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time In: ";
            // 
            // lblTimeInTime
            // 
            this.lblTimeInTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeInTime.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInTime.Location = new System.Drawing.Point(76, 53);
            this.lblTimeInTime.Name = "lblTimeInTime";
            this.lblTimeInTime.Size = new System.Drawing.Size(89, 19);
            this.lblTimeInTime.TabIndex = 1;
            this.lblTimeInTime.Text = "9:30 AM";
            this.lblTimeInTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 44);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "The Quick Brown Fox Jumps Over ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employee Name:";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(76, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 19);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee Id: ";
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.Maroon;
            this.btnTimeOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTimeOut.FlatAppearance.BorderSize = 0;
            this.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOut.ForeColor = System.Drawing.Color.White;
            this.btnTimeOut.Location = new System.Drawing.Point(0, 154);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(171, 31);
            this.btnTimeOut.TabIndex = 7;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 27);
            this.panel1.TabIndex = 8;
            // 
            // PresentEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimeInTime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PresentEmployeeUserControl";
            this.Size = new System.Drawing.Size(171, 185);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeInTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Panel panel1;
    }
}
