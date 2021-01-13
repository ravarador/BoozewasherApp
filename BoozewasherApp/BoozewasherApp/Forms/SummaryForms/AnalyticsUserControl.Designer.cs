
namespace BoozewasherApp.Forms.SummaryForms
{
    partial class AnalyticsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpboxDate = new System.Windows.Forms.GroupBox();
            this.datePickerSelectDate = new System.Windows.Forms.DateTimePicker();
            this.radSelectDateRange = new System.Windows.Forms.RadioButton();
            this.radSelectDate = new System.Windows.Forms.RadioButton();
            this.grpboxDateRange = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerDateToRange = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateFromRange = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grpboxDate.SuspendLayout();
            this.grpboxDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(313, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(667, 536);
            this.formsPlot1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(31, 277);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(223, 23);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpboxDate
            // 
            this.grpboxDate.Controls.Add(this.datePickerSelectDate);
            this.grpboxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDate.Location = new System.Drawing.Point(31, 49);
            this.grpboxDate.Name = "grpboxDate";
            this.grpboxDate.Size = new System.Drawing.Size(223, 54);
            this.grpboxDate.TabIndex = 14;
            this.grpboxDate.TabStop = false;
            this.grpboxDate.Text = "Select Date";
            // 
            // datePickerSelectDate
            // 
            this.datePickerSelectDate.Location = new System.Drawing.Point(9, 22);
            this.datePickerSelectDate.MaxDate = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            this.datePickerSelectDate.Name = "datePickerSelectDate";
            this.datePickerSelectDate.Size = new System.Drawing.Size(200, 23);
            this.datePickerSelectDate.TabIndex = 4;
            this.datePickerSelectDate.Value = new System.DateTime(2021, 1, 13, 23, 14, 35, 0);
            // 
            // radSelectDateRange
            // 
            this.radSelectDateRange.AutoSize = true;
            this.radSelectDateRange.FlatAppearance.BorderSize = 0;
            this.radSelectDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radSelectDateRange.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSelectDateRange.Location = new System.Drawing.Point(138, 20);
            this.radSelectDateRange.Name = "radSelectDateRange";
            this.radSelectDateRange.Size = new System.Drawing.Size(119, 20);
            this.radSelectDateRange.TabIndex = 13;
            this.radSelectDateRange.Text = "Select Date Range";
            this.radSelectDateRange.UseVisualStyleBackColor = true;
            this.radSelectDateRange.Click += new System.EventHandler(this.radSelectDate_Click);
            // 
            // radSelectDate
            // 
            this.radSelectDate.AutoSize = true;
            this.radSelectDate.Checked = true;
            this.radSelectDate.FlatAppearance.BorderSize = 0;
            this.radSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radSelectDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSelectDate.Location = new System.Drawing.Point(31, 20);
            this.radSelectDate.Name = "radSelectDate";
            this.radSelectDate.Size = new System.Drawing.Size(83, 20);
            this.radSelectDate.TabIndex = 12;
            this.radSelectDate.TabStop = true;
            this.radSelectDate.Text = "Select Date";
            this.radSelectDate.UseVisualStyleBackColor = true;
            this.radSelectDate.Click += new System.EventHandler(this.radSelectDate_Click);
            // 
            // grpboxDateRange
            // 
            this.grpboxDateRange.Controls.Add(this.label2);
            this.grpboxDateRange.Controls.Add(this.label1);
            this.grpboxDateRange.Controls.Add(this.datePickerDateToRange);
            this.grpboxDateRange.Controls.Add(this.datePickerDateFromRange);
            this.grpboxDateRange.Enabled = false;
            this.grpboxDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxDateRange.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDateRange.Location = new System.Drawing.Point(31, 118);
            this.grpboxDateRange.Name = "grpboxDateRange";
            this.grpboxDateRange.Size = new System.Drawing.Size(223, 153);
            this.grpboxDateRange.TabIndex = 11;
            this.grpboxDateRange.TabStop = false;
            this.grpboxDateRange.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date From:";
            // 
            // datePickerDateToRange
            // 
            this.datePickerDateToRange.Location = new System.Drawing.Point(9, 112);
            this.datePickerDateToRange.MaxDate = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            this.datePickerDateToRange.Name = "datePickerDateToRange";
            this.datePickerDateToRange.Size = new System.Drawing.Size(200, 23);
            this.datePickerDateToRange.TabIndex = 1;
            this.datePickerDateToRange.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // datePickerDateFromRange
            // 
            this.datePickerDateFromRange.Location = new System.Drawing.Point(9, 44);
            this.datePickerDateFromRange.MaxDate = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            this.datePickerDateFromRange.Name = "datePickerDateFromRange";
            this.datePickerDateFromRange.Size = new System.Drawing.Size(200, 23);
            this.datePickerDateFromRange.TabIndex = 0;
            this.datePickerDateFromRange.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(31, 364);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(223, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(31, 306);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(223, 23);
            this.btnMaximize.TabIndex = 17;
            this.btnMaximize.Text = "Maximize";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(31, 335);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(223, 23);
            this.btnCopy.TabIndex = 18;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // AnalyticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpboxDate);
            this.Controls.Add(this.radSelectDateRange);
            this.Controls.Add(this.radSelectDate);
            this.Controls.Add(this.grpboxDateRange);
            this.Controls.Add(this.formsPlot1);
            this.Name = "AnalyticsUserControl";
            this.Size = new System.Drawing.Size(983, 542);
            this.grpboxDate.ResumeLayout(false);
            this.grpboxDateRange.ResumeLayout(false);
            this.grpboxDateRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpboxDate;
        private System.Windows.Forms.DateTimePicker datePickerSelectDate;
        private System.Windows.Forms.RadioButton radSelectDateRange;
        private System.Windows.Forms.RadioButton radSelectDate;
        private System.Windows.Forms.GroupBox grpboxDateRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerDateToRange;
        private System.Windows.Forms.DateTimePicker datePickerDateFromRange;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCopy;
    }
}
