namespace BoozewasherApp.Forms.SummaryForms
{
    partial class SummaryChart
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpboxDate = new System.Windows.Forms.GroupBox();
            this.datePickerSelectDate = new System.Windows.Forms.DateTimePicker();
            this.radSelectDateRange = new System.Windows.Forms.RadioButton();
            this.radSelectDate = new System.Windows.Forms.RadioButton();
            this.grpboxDateRange = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerDateToRange = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateFromRange = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpboxDate.SuspendLayout();
            this.grpboxDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(257, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(710, 502);
            this.formsPlot1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gross Income";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Expenses";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(58, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Services Count";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // grpboxDate
            // 
            this.grpboxDate.Controls.Add(this.datePickerSelectDate);
            this.grpboxDate.Location = new System.Drawing.Point(12, 43);
            this.grpboxDate.Name = "grpboxDate";
            this.grpboxDate.Size = new System.Drawing.Size(223, 54);
            this.grpboxDate.TabIndex = 9;
            this.grpboxDate.TabStop = false;
            this.grpboxDate.Text = "Select Date";
            // 
            // datePickerSelectDate
            // 
            this.datePickerSelectDate.Location = new System.Drawing.Point(9, 19);
            this.datePickerSelectDate.Name = "datePickerSelectDate";
            this.datePickerSelectDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerSelectDate.TabIndex = 4;
            // 
            // radSelectDateRange
            // 
            this.radSelectDateRange.AutoSize = true;
            this.radSelectDateRange.Location = new System.Drawing.Point(119, 14);
            this.radSelectDateRange.Name = "radSelectDateRange";
            this.radSelectDateRange.Size = new System.Drawing.Size(116, 17);
            this.radSelectDateRange.TabIndex = 8;
            this.radSelectDateRange.Text = "Select Date Range";
            this.radSelectDateRange.UseVisualStyleBackColor = true;
            this.radSelectDateRange.Click += new System.EventHandler(this.radSelectDate_Click);
            // 
            // radSelectDate
            // 
            this.radSelectDate.AutoSize = true;
            this.radSelectDate.Checked = true;
            this.radSelectDate.Location = new System.Drawing.Point(12, 14);
            this.radSelectDate.Name = "radSelectDate";
            this.radSelectDate.Size = new System.Drawing.Size(81, 17);
            this.radSelectDate.TabIndex = 7;
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
            this.grpboxDateRange.Location = new System.Drawing.Point(12, 112);
            this.grpboxDateRange.Name = "grpboxDateRange";
            this.grpboxDateRange.Size = new System.Drawing.Size(223, 153);
            this.grpboxDateRange.TabIndex = 6;
            this.grpboxDateRange.TabStop = false;
            this.grpboxDateRange.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date From:";
            // 
            // datePickerDateToRange
            // 
            this.datePickerDateToRange.Location = new System.Drawing.Point(9, 109);
            this.datePickerDateToRange.Name = "datePickerDateToRange";
            this.datePickerDateToRange.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateToRange.TabIndex = 1;
            // 
            // datePickerDateFromRange
            // 
            this.datePickerDateFromRange.Location = new System.Drawing.Point(9, 41);
            this.datePickerDateFromRange.Name = "datePickerDateFromRange";
            this.datePickerDateFromRange.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateFromRange.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(160, 375);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // SummaryChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 526);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpboxDate);
            this.Controls.Add(this.radSelectDateRange);
            this.Controls.Add(this.radSelectDate);
            this.Controls.Add(this.grpboxDateRange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formsPlot1);
            this.Name = "SummaryChart";
            this.Text = "Summary Chart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxDate.ResumeLayout(false);
            this.grpboxDateRange.ResumeLayout(false);
            this.grpboxDateRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpboxDate;
        private System.Windows.Forms.DateTimePicker datePickerSelectDate;
        private System.Windows.Forms.RadioButton radSelectDateRange;
        private System.Windows.Forms.RadioButton radSelectDate;
        private System.Windows.Forms.GroupBox grpboxDateRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerDateToRange;
        private System.Windows.Forms.DateTimePicker datePickerDateFromRange;
        private System.Windows.Forms.Button btnGenerate;
    }
}