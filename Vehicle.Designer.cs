namespace Ayubo_New
{
    partial class Vehicle
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
            this.cmbRegno = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDRrate = new System.Windows.Forms.TextBox();
            this.txtMrate = new System.Windows.Forms.TextBox();
            this.txtWrate = new System.Windows.Forms.TextBox();
            this.txtDrate = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtVtype = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ayuboDataSet = new Ayubo_New.AyuboDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Ayubo_New.AyuboDataSetTableAdapters.VehicleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboDataSet2 = new Ayubo_New.AyuboDataSet2();
            this.vehicleTableAdapter1 = new Ayubo_New.AyuboDataSet2TableAdapters.VehicleTableAdapter();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRegno
            // 
            this.cmbRegno.FormattingEnabled = true;
            this.cmbRegno.Location = new System.Drawing.Point(165, 44);
            this.cmbRegno.Name = "cmbRegno";
            this.cmbRegno.Size = new System.Drawing.Size(100, 24);
            this.cmbRegno.TabIndex = 39;
            this.cmbRegno.SelectedIndexChanged += new System.EventHandler(this.cmbRegno_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(325, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 43);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "DrRate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "MRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "WRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "DRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "V Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Reg NO";
            // 
            // txtDRrate
            // 
            this.txtDRrate.Location = new System.Drawing.Point(174, 438);
            this.txtDRrate.Name = "txtDRrate";
            this.txtDRrate.Size = new System.Drawing.Size(100, 22);
            this.txtDRrate.TabIndex = 30;
            // 
            // txtMrate
            // 
            this.txtMrate.Location = new System.Drawing.Point(165, 382);
            this.txtMrate.Name = "txtMrate";
            this.txtMrate.Size = new System.Drawing.Size(100, 22);
            this.txtMrate.TabIndex = 29;
            // 
            // txtWrate
            // 
            this.txtWrate.Location = new System.Drawing.Point(165, 311);
            this.txtWrate.Name = "txtWrate";
            this.txtWrate.Size = new System.Drawing.Size(100, 22);
            this.txtWrate.TabIndex = 28;
            // 
            // txtDrate
            // 
            this.txtDrate.Location = new System.Drawing.Point(165, 244);
            this.txtDrate.Name = "txtDrate";
            this.txtDrate.Size = new System.Drawing.Size(100, 22);
            this.txtDrate.TabIndex = 27;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(165, 186);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 22);
            this.txtMake.TabIndex = 26;
            // 
            // txtVtype
            // 
            this.txtVtype.Location = new System.Drawing.Point(165, 112);
            this.txtVtype.Name = "txtVtype";
            this.txtVtype.Size = new System.Drawing.Size(100, 22);
            this.txtVtype.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(325, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 37);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(325, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 41);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(325, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 38);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(325, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 37);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ayuboDataSet
            // 
            this.ayuboDataSet.DataSetName = "AyuboDataSet";
            this.ayuboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.ayuboDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.vTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(513, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(245, 184);
            this.dataGridView1.TabIndex = 40;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            // 
            // vTypeDataGridViewTextBoxColumn
            // 
            this.vTypeDataGridViewTextBoxColumn.DataPropertyName = "VType";
            this.vTypeDataGridViewTextBoxColumn.HeaderText = "VType";
            this.vTypeDataGridViewTextBoxColumn.Name = "vTypeDataGridViewTextBoxColumn";
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataMember = "Vehicle";
            this.vehicleBindingSource1.DataSource = this.ayuboDataSet2;
            // 
            // ayuboDataSet2
            // 
            this.ayuboDataSet2.DataSetName = "AyuboDataSet2";
            this.ayuboDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTableAdapter1
            // 
            this.vehicleTableAdapter1.ClearBeforeFill = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(405, 443);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(367, 58);
            this.label19.TabIndex = 57;
            this.label19.Text = "AYUBO DRIVE";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(538, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 41);
            this.button3.TabIndex = 58;
            this.button3.Text = "Go to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_51925901;
            this.ClientSize = new System.Drawing.Size(905, 590);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbRegno);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDRrate);
            this.Controls.Add(this.txtMrate);
            this.Controls.Add(this.txtWrate);
            this.Controls.Add(this.txtDrate);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtVtype);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRegno;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDRrate;
        private System.Windows.Forms.TextBox txtMrate;
        private System.Windows.Forms.TextBox txtWrate;
        private System.Windows.Forms.TextBox txtDrate;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVtype;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private AyuboDataSet ayuboDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private AyuboDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboDataSet2 ayuboDataSet2;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
        private AyuboDataSet2TableAdapters.VehicleTableAdapter vehicleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
    }
}