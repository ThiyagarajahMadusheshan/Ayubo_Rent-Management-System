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
    public partial class DayTour : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NHM6UBNJ\\SQLEXPRESS;Initial Catalog=Ayubo;Integrated Security=True");
        double extrahrCharge, extrakmcharge;
        public DayTour()
        {
               InitializeComponent();
        }
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Pid from Package", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPid.DataSource = dt;
            cmbPid.DisplayMember = "Pid";
            cmbPid.ValueMember = "Pid";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String search = "select * from package where Pid ='" + cmbPid.Text + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtPname.Text = dr["Pname"].ToString();
                    txtPrate.Text = dr["PRate"].ToString();
                    textBox1.Text = dr["Vtype"].ToString();
                    txtMkm.Text = dr["MaxKm"].ToString();
                    txtMhrs.Text = dr["MaxHrs"].ToString();
                    txtKrate.Text = dr["exKmRate"].ToString();
                    txtHrate.Text = dr["exHrRate"].ToString();
                    
                    
                }
                else
                    MessageBox.Show("Package not found");
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            } 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DayTour_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void btnChours_Click(object sender, EventArgs e)
        {
            DateTime starttime,endtime;
            TimeSpan timediff;

            starttime = DateTime.Parse(dtnStime.Text);
            endtime = DateTime.Parse(dtnEtime.Text);

            timediff = endtime - starttime;
            int hrs, max_hrs, extra_time;

            hrs = timediff.Hours;
            txtNhours.Text = Convert.ToString(hrs);

            max_hrs = int.Parse(txtMhrs.Text);
            if(hrs>max_hrs)
            {
                extra_time = hrs - max_hrs;
                txtExHrs.Text = extra_time.ToString();

                double extrahrcharge, extrahr_rate;
                extrahr_rate = double.Parse(txtHrate.Text);
                extrahrcharge = extra_time * extrahr_rate;
                txtHcharge.Text = extrahrcharge.ToString();
            }
        }

        private void btnCalkm_Click(object sender, EventArgs e)
        {
            int Startkm,endKm,nokm;
            Startkm = int.Parse(txtSkmr.Text);
            endKm = int.Parse(txtEkmr.Text);
            nokm = endKm - Startkm;
            txtNkm.Text = nokm.ToString();

            double maxkm, extrakm;
            maxkm = int.Parse(txtMkm.Text);
            extrakm = nokm * maxkm;
            if (nokm> maxkm)
            {
                extrakm = nokm - maxkm;
                txtEkm.Text = extrakm.ToString();

                double extrakmrate;
                extrakmrate = double.Parse(txtKrate.Text);
                extrakmcharge = extrakm * extrakmrate;
                txtEkmc.Text = extrakmcharge.ToString();
            }
            else
            {
                MessageBox.Show("You dont have any extra amount to be payed");
            }

        }

        private void btnCday_Click(object sender, EventArgs e)
        {
            double prate, totalcost;
            prate = double.Parse(txtPrate.Text);
            extrahrCharge = double.Parse(txtHcharge.Text);
            extrakmcharge = double.Parse(txtEkmc.Text);

             totalcost = prate + extrahrCharge + extrakmcharge;
            txtTcost.Text = totalcost.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPname.Clear();
            txtPrate.Clear();
            txtMkm.Clear();
            txtMhrs.Clear();
            txtKrate.Clear();
            txtHrate.Clear();
            txtSkmr.Clear();
            txtSkmr.Clear();
            txtNkm.Clear();
            txtEkm.Clear();
            txtEkmc.Clear();
            txtTcost.Clear();
            txtEkmr.Clear();
            txtNhours.Clear();
            txtHcharge.Clear();
            txtExHrs.Clear();

        }

        private void txtTcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu openform = new MainMenu();
            openform.Show();
        }
    }
}
