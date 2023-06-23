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
    public partial class LongTour : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NHM6UBNJ\\SQLEXPRESS;Initial Catalog=Ayubo;Integrated Security=True");
        
        public LongTour()
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
                    txtMkm.Text = dr["MaxKm"].ToString();
                    txtMhrs.Text = dr["MaxHrs"].ToString();
                    txtNRateD.Text = dr["drNightRate"].ToString();
                    txtNRateV.Text = dr["vehicleNightRate"].ToString();
                    txtExtraKmRate.Text = dr["exKmRate"].ToString();


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

        private void LongTour_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void txtNoDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            DateTime rentdate, returndate;
            TimeSpan dateDiff;
            double nDays;

            rentdate = DateTime.Parse(dtnRent.Text);
            returndate = DateTime.Parse(dtnReturn.Text);
            dateDiff = returndate - rentdate;
            nDays = dateDiff.TotalDays;
            txtNoDays.Text = nDays.ToString();


        }

        private void btnCalkm_Click(object sender, EventArgs e)
        {
            int Startkm, endKm, nokm;
            Startkm = int.Parse(txtSkmr.Text);
            endKm = int.Parse(txtEkmr.Text);
            nokm = endKm - Startkm;
            txtNkm.Text = nokm.ToString();

            double maxkm, extrakm,totalkm, extraKmRate, extraKmCharge;
            int noofdays;
            noofdays = int.Parse(txtNoDays.Text);
            maxkm = int.Parse(txtMkm.Text);
            extraKmRate = double.Parse(txtExtraKmRate.Text);
            totalkm = noofdays * maxkm;
            if (nokm > totalkm)
            {
                extrakm = nokm - totalkm;
                txtEkm.Text = extrakm.ToString();

                extraKmCharge = extrakm * extraKmRate;
                txtEkmc.Text = extraKmCharge.ToString();

                
            }
            else
            {
                txtEkm.Text = "0";
                txtEkmc.Text = "0";
                
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pRate, totalPchage;
            int noofdays;
            noofdays = int.Parse(txtNoDays.Text);
            pRate = double.Parse(txtPrate.Text);
            totalPchage = pRate * noofdays;
            txtBaseHire.Text = totalPchage.ToString();

            double nightVehicle, nightDriver, perDaynight, totalNight;
            nightVehicle = double.Parse(txtNRateV.Text);
            nightDriver = double.Parse(txtNRateD.Text);
            perDaynight = nightDriver + nightVehicle;
            totalNight = perDaynight * noofdays;
            txtOverNight.Text = totalNight.ToString();

            txtextraKmCharge.Text = txtEkmc.Text;

            double extrakmcharge, totalcost;
            extrakmcharge = double.Parse(txtextraKmCharge.Text);
            totalcost = totalPchage + totalNight + extrakmcharge;
            txtTotalCost.Text = totalcost.ToString();

            MessageBox.Show("Total is '" + totalcost);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu openform = new MainMenu();
            openform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPname.Clear();
            txtPrate.Clear();
            txtMkm.Clear();
            txtMhrs.Clear();
            txtSkmr.Clear();
            txtSkmr.Clear();
            txtNkm.Clear();
            txtEkm.Clear();
            txtEkmc.Clear();
            txtEkmr.Clear();
            txtNoDays.Clear();
            txtBaseHire.Clear();
            
        }
    }
}
