namespace Ayubo_New
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDays = new System.Windows.Forms.Button();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.txtWeeks = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtnRent = new System.Windows.Forms.DateTimePicker();
            this.dtnReturn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDrRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDRate = new System.Windows.Forms.TextBox();
            this.txtWRate = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtMRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnCtot = new System.Windows.Forms.Button();
            this.chkDr = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_5192590;
            this.groupBox1.Controls.Add(this.btnDays);
            this.groupBox1.Controls.Add(this.txtMonths);
            this.groupBox1.Controls.Add(this.txtWeeks);
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtnRent);
            this.groupBox1.Controls.Add(this.dtnReturn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNoDays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No of Days";
            // 
            // btnDays
            // 
            this.btnDays.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDays.Location = new System.Drawing.Point(399, 149);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(237, 49);
            this.btnDays.TabIndex = 16;
            this.btnDays.Text = "CALCULATE DAYS";
            this.btnDays.UseVisualStyleBackColor = true;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(573, 28);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(138, 26);
            this.txtMonths.TabIndex = 15;
            // 
            // txtWeeks
            // 
            this.txtWeeks.Location = new System.Drawing.Point(573, 61);
            this.txtWeeks.Name = "txtWeeks";
            this.txtWeeks.Size = new System.Drawing.Size(138, 26);
            this.txtWeeks.TabIndex = 14;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(573, 98);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(138, 26);
            this.txtDays.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weeks";
            // 
            // dtnRent
            // 
            this.dtnRent.Location = new System.Drawing.Point(158, 28);
            this.dtnRent.Name = "dtnRent";
            this.dtnRent.Size = new System.Drawing.Size(277, 26);
            this.dtnRent.TabIndex = 9;
            // 
            // dtnReturn
            // 
            this.dtnReturn.Location = new System.Drawing.Point(158, 66);
            this.dtnReturn.Name = "dtnReturn";
            this.dtnReturn.Size = new System.Drawing.Size(277, 26);
            this.dtnReturn.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "No of Days";
            // 
            // txtNoDays
            // 
            this.txtNoDays.Location = new System.Drawing.Point(158, 106);
            this.txtNoDays.Name = "txtNoDays";
            this.txtNoDays.Size = new System.Drawing.Size(163, 26);
            this.txtNoDays.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Returned Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rented Date ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_51925901;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtDrRate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbRegNo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDRate);
            this.groupBox2.Controls.Add(this.txtWRate);
            this.groupBox2.Controls.Add(this.txtMake);
            this.groupBox2.Controls.Add(this.txtMRate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Details";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.Location = new System.Drawing.Point(237, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(228, 44);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDrRate
            // 
            this.txtDrRate.Location = new System.Drawing.Point(549, 128);
            this.txtDrRate.Name = "txtDrRate";
            this.txtDrRate.Size = new System.Drawing.Size(162, 26);
            this.txtDrRate.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Driver Rate";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(104, 47);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(164, 31);
            this.cmbRegNo.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Week Rate";
            // 
            // txtDRate
            // 
            this.txtDRate.Location = new System.Drawing.Point(104, 87);
            this.txtDRate.Name = "txtDRate";
            this.txtDRate.Size = new System.Drawing.Size(164, 26);
            this.txtDRate.TabIndex = 7;
            // 
            // txtWRate
            // 
            this.txtWRate.Location = new System.Drawing.Point(106, 128);
            this.txtWRate.Name = "txtWRate";
            this.txtWRate.Size = new System.Drawing.Size(164, 26);
            this.txtWRate.TabIndex = 6;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(549, 39);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(162, 26);
            this.txtMake.TabIndex = 5;
            // 
            // txtMRate
            // 
            this.txtMRate.Location = new System.Drawing.Point(549, 89);
            this.txtMRate.Name = "txtMRate";
            this.txtMRate.Size = new System.Drawing.Size(162, 26);
            this.txtMRate.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Day Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "RegNo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Make";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monthly Rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "TOTAL COST";
            // 
            // txtTot
            // 
            this.txtTot.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(143, 541);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(211, 26);
            this.txtTot.TabIndex = 10;
            // 
            // btnCtot
            // 
            this.btnCtot.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtot.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCtot.Location = new System.Drawing.Point(201, 458);
            this.btnCtot.Name = "btnCtot";
            this.btnCtot.Size = new System.Drawing.Size(188, 43);
            this.btnCtot.TabIndex = 9;
            this.btnCtot.Text = "Calculate Total Amount";
            this.btnCtot.UseVisualStyleBackColor = true;
            this.btnCtot.Click += new System.EventHandler(this.btnCtot_Click);
            // 
            // chkDr
            // 
            this.chkDr.AutoSize = true;
            this.chkDr.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDr.Location = new System.Drawing.Point(12, 467);
            this.chkDr.Name = "chkDr";
            this.chkDr.Size = new System.Drawing.Size(128, 27);
            this.chkDr.TabIndex = 8;
            this.chkDr.Text = "With Driver";
            this.chkDr.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnClear.Location = new System.Drawing.Point(424, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 43);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 38);
            this.button3.TabIndex = 57;
            this.button3.Text = "Go to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(403, 524);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(306, 48);
            this.label19.TabIndex = 57;
            this.label19.Text = "AYUBO DRIVE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_51925901;
            this.ClientSize = new System.Drawing.Size(742, 627);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.btnCtot);
            this.Controls.Add(this.chkDr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " Rent Calculation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.TextBox txtWeeks;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtnRent;
        private System.Windows.Forms.DateTimePicker dtnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDrRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDRate;
        private System.Windows.Forms.TextBox txtWRate;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtMRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button btnCtot;
        private System.Windows.Forms.CheckBox chkDr;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
    }
}

