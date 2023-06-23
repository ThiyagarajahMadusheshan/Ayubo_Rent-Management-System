using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_New
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
           

            InitializeComponent();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle V = new Vehicle();
             V.Show();
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package P = new Package();
            P.Show();
        }

        private void rentCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 R = new Form1();
            R.Show();

        }

        private void calculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void hireCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayTour D = new DayTour();
            D.Show();
        }

        private void longTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LongTour D = new LongTour();
            D.Show();
        }
    }
}
