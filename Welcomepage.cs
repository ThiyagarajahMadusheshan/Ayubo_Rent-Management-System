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
    public partial class Welcome_page : Form
    {
        public Welcome_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login openform = new Login();
            openform.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
    }

       
        
            

        private void contactUsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Contact_us C = new Contact_us();
            C.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About_Us A = new About_Us();
            A.Show();
        }

        private void contactUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Contact_us A = new Contact_us();
            A.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        }
        }
        
