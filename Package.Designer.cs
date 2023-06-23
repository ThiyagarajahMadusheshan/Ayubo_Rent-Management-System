namespace Ayubo_New
{
    partial class Package
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
            this.cmbPid = new System.Windows.Forms.ComboBox();
            this.txtNRateD = new System.Windows.Forms.TextBox();
            this.txtNRateV = new System.Windows.Forms.TextBox();
            this.txtHrate = new System.Windows.Forms.TextBox();
            this.txtVrright = new System.Windows.Forms.Label();
            this.txtDnrate = new System.Windows.Forms.Label();
            this.txtEhrate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMhrs = new System.Windows.Forms.TextBox();
            this.txtMkm = new System.Windows.Forms.TextBox();
            this.txtPrate = new System.Windows.Forms.TextBox();
            this.txtVtype = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtKrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboDataSet3 = new Ayubo_New.AyuboDataSet3();
            this.packageTableAdapter = new Ayubo_New.AyuboDataSet3TableAdapters.PackageTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPid
            // 
            this.cmbPid.FormattingEnabled = true;
            this.cmbPid.Location = new System.Drawing.Point(208, 25);
            this.cmbPid.Name = "cmbPid";
            this.cmbPid.Size = new System.Drawing.Size(104, 24);
            this.cmbPid.TabIndex = 52;
            // 
            // txtNRateD
            // 
            this.txtNRateD.Location = new System.Drawing.Point(208, 471);
            this.txtNRateD.Name = "txtNRateD";
            this.txtNRateD.Size = new System.Drawing.Size(100, 22);
            this.txtNRateD.TabIndex = 51;
            // 
            // txtNRateV
            // 
            this.txtNRateV.Location = new System.Drawing.Point(208, 519);
            this.txtNRateV.Name = "txtNRateV";
            this.txtNRateV.Size = new System.Drawing.Size(100, 22);
            this.txtNRateV.TabIndex = 50;
            // 
            // txtHrate
            // 
            this.txtHrate.Location = new System.Drawing.Point(208, 411);
            this.txtHrate.Name = "txtHrate";
            this.txtHrate.Size = new System.Drawing.Size(100, 22);
            this.txtHrate.TabIndex = 49;
            // 
            // txtVrright
            // 
            this.txtVrright.AutoSize = true;
            this.txtVrright.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrright.Location = new System.Drawing.Point(11, 519);
            this.txtVrright.Name = "txtVrright";
            this.txtVrright.Size = new System.Drawing.Size(186, 28);
            this.txtVrright.TabIndex = 48;
            this.txtVrright.Text = "vehicleNightRate";
            // 
            // txtDnrate
            // 
            this.txtDnrate.AutoSize = true;
            this.txtDnrate.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDnrate.Location = new System.Drawing.Point(22, 471);
            this.txtDnrate.Name = "txtDnrate";
            this.txtDnrate.Size = new System.Drawing.Size(138, 28);
            this.txtDnrate.TabIndex = 47;
            this.txtDnrate.Text = "drNightRate";
            // 
            // txtEhrate
            // 
            this.txtEhrate.AutoSize = true;
            this.txtEhrate.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEhrate.Location = new System.Drawing.Point(35, 411);
            this.txtEhrate.Name = "txtEhrate";
            this.txtEhrate.Size = new System.Drawing.Size(107, 28);
            this.txtEhrate.TabIndex = 46;
            this.txtEhrate.Text = "exHrRate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "exKmRate";
            // 
            // txtMhrs
            // 
            this.txtMhrs.Location = new System.Drawing.Point(208, 311);
            this.txtMhrs.Name = "txtMhrs";
            this.txtMhrs.Size = new System.Drawing.Size(100, 22);
            this.txtMhrs.TabIndex = 44;
            // 
            // txtMkm
            // 
            this.txtMkm.Location = new System.Drawing.Point(208, 250);
            this.txtMkm.Name = "txtMkm";
            this.txtMkm.Size = new System.Drawing.Size(100, 22);
            this.txtMkm.TabIndex = 43;
            // 
            // txtPrate
            // 
            this.txtPrate.Location = new System.Drawing.Point(208, 193);
            this.txtPrate.Name = "txtPrate";
            this.txtPrate.Size = new System.Drawing.Size(100, 22);
            this.txtPrate.TabIndex = 42;
            // 
            // txtVtype
            // 
            this.txtVtype.Location = new System.Drawing.Point(208, 131);
            this.txtVtype.Name = "txtVtype";
            this.txtVtype.Size = new System.Drawing.Size(100, 22);
            this.txtVtype.TabIndex = 41;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(208, 79);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(100, 22);
            this.txtPname.TabIndex = 40;
            // 
            // txtKrate
            // 
            this.txtKrate.Location = new System.Drawing.Point(208, 360);
            this.txtKrate.Name = "txtKrate";
            this.txtKrate.Size = new System.Drawing.Size(100, 22);
            this.txtKrate.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Maxhrs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Maxkm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "PRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "VType";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(42, 74);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(83, 28);
            this.txt.TabIndex = 34;
            this.txt.Text = "PName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pid";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(338, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 44);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(338, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 39);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(338, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 38);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(338, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 37);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(338, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 41);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(392, 458);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(367, 58);
            this.label19.TabIndex = 58;
            this.label19.Text = "AYUBO DRIVE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(560, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 59;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "Pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataMember = "Package";
            this.packageBindingSource.DataSource = this.ayuboDataSet3;
            // 
            // ayuboDataSet3
            // 
            this.ayuboDataSet3.DataSetName = "AyuboDataSet3";
            this.ayuboDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageTableAdapter
            // 
            this.packageTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(585, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 41);
            this.button3.TabIndex = 60;
            this.button3.Text = "Go to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_5192590;
            this.ClientSize = new System.Drawing.Size(826, 573);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbPid);
            this.Controls.Add(this.txtNRateD);
            this.Controls.Add(this.txtNRateV);
            this.Controls.Add(this.txtHrate);
            this.Controls.Add(this.txtVrright);
            this.Controls.Add(this.txtDnrate);
            this.Controls.Add(this.txtEhrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMhrs);
            this.Controls.Add(this.txtMkm);
            this.Controls.Add(this.txtPrate);
            this.Controls.Add(this.txtVtype);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtKrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Name = "Package";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPid;
        private System.Windows.Forms.TextBox txtNRateD;
        private System.Windows.Forms.TextBox txtNRateV;
        private System.Windows.Forms.TextBox txtHrate;
        private System.Windows.Forms.Label txtVrright;
        private System.Windows.Forms.Label txtDnrate;
        private System.Windows.Forms.Label txtEhrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMhrs;
        private System.Windows.Forms.TextBox txtMkm;
        private System.Windows.Forms.TextBox txtPrate;
        private System.Windows.Forms.TextBox txtVtype;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtKrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboDataSet3 ayuboDataSet3;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private AyuboDataSet3TableAdapters.PackageTableAdapter packageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}