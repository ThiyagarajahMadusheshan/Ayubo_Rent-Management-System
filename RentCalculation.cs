using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_New
{
    public partial class Form1 : Form
    {
       SqlConnection con = new SqlConnection("Data Source=LAPTOP-NHM6UBNJ\\SQLEXPRESS;Initial Catalog=Ayubo;Integrated Security=True");
       int totDays, months, remainder, weeks, days;

        public Form1()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select RegNo from Vehicle", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbRegNo.DataSource = dt;
            cmbRegNo.DisplayMember = "RegNo";
            cmbRegNo.ValueMember = "RegNo";
        }


        private void btnDays_Click(object sender, EventArgs e)
        {
            DateTime rentdate, returndate;
            TimeSpan dateDiff;
            double nDays;

            rentdate = DateTime.Parse(dtnRent.Text); //Selecting the rent date

            returndate = DateTime.Parse(dtnReturn.Text); //selecting the returned date
            dateDiff = returndate - rentdate;
            nDays = dateDiff.TotalDays;
            txtNoDays.Text = nDays.ToString();


            totDays = int.Parse(txtNoDays.Text);

            // calculate number of months 
            months = totDays / 30;
            txtMonths.Text = months.ToString();

            remainder = totDays % 30;
            //calculate weeks
            weeks = remainder / 7;
            txtWeeks.Text = weeks.ToString();
            //calculate days
            days = remainder % 7;
            txtDays.Text = days.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlst = "select * from Vehicle where regNo='" + cmbRegNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlst, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMake.Text = dr["Make"].ToString();
                    txtDRate.Text = dr["DRate"].ToString();
                    txtWRate.Text = dr["WRate"].ToString();
                    txtMRate.Text = dr["MRate"].ToString();
                    txtDrRate.Text = dr["DrRate"].ToString();
                }
                else
                    MessageBox.Show("Vehicle not found");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void btnCtot_Click(object sender, EventArgs e)
        {
            double MRate, WRate, DRate, DrRate, amt;
            double totCost;
            MRate = double.Parse(txtMRate.Text);
            WRate = double.Parse(txtWRate.Text);
            DRate = double.Parse(txtDRate.Text);
            DrRate = double.Parse(txtDrRate.Text);

            amt = MRate * months + WRate * weeks + DRate * days;
            if (chkDr.Checked == true)
            {
                totCost = amt + DrRate * totDays;
            }
            else
            {
                totCost = amt;
            }
            txtTot.Text = totCost.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoDays.Clear();
            txtMonths.Clear();
            txtWeeks.Clear();
            txtDays.Clear();
            txtDRate.Clear();
            txtWRate.Clear();
            txtMake.Clear();
            txtMRate.Clear();
            txtDrRate.Clear();
            txtTot.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu openform = new MainMenu();
            openform.Show();
        }
    }
}
