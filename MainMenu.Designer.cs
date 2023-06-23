namespace Ayubo_New
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.packageToolStripMenuItem,
            this.calculationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // packageToolStripMenuItem
            // 
            this.packageToolStripMenuItem.Name = "packageToolStripMenuItem";
            this.packageToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.packageToolStripMenuItem.Text = "Package";
            this.packageToolStripMenuItem.Click += new System.EventHandler(this.packageToolStripMenuItem_Click);
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCalculationToolStripMenuItem,
            this.hireCalculationToolStripMenuItem,
            this.longTourToolStripMenuItem});
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.calculationToolStripMenuItem.Text = "Calculation";
            this.calculationToolStripMenuItem.Click += new System.EventHandler(this.calculationToolStripMenuItem_Click);
            // 
            // rentCalculationToolStripMenuItem
            // 
            this.rentCalculationToolStripMenuItem.Name = "rentCalculationToolStripMenuItem";
            this.rentCalculationToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.rentCalculationToolStripMenuItem.Text = "Rent Calculation";
            this.rentCalculationToolStripMenuItem.Click += new System.EventHandler(this.rentCalculationToolStripMenuItem_Click);
            // 
            // hireCalculationToolStripMenuItem
            // 
            this.hireCalculationToolStripMenuItem.Name = "hireCalculationToolStripMenuItem";
            this.hireCalculationToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.hireCalculationToolStripMenuItem.Text = "Day Tour";
            this.hireCalculationToolStripMenuItem.Click += new System.EventHandler(this.hireCalculationToolStripMenuItem_Click);
            // 
            // longTourToolStripMenuItem
            // 
            this.longTourToolStripMenuItem.Name = "longTourToolStripMenuItem";
            this.longTourToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.longTourToolStripMenuItem.Text = "Long Tour";
            this.longTourToolStripMenuItem.Click += new System.EventHandler(this.longTourToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(218, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(464, 72);
            this.label19.TabIndex = 57;
            this.label19.Text = "AYUBO DRIVE";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_New.Properties.Resources.car_sunset_5192590;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label19;
    }
}