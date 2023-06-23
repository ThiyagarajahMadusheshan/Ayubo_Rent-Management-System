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
    public partial class Package : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NHM6UBNJ\\SQLEXPRESS;Initial Catalog=Ayubo;Integrated Security=True");
        public Package()
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
                    txtVtype.Text = dr["Vtype"].ToString();
                    txtPrate.Text = dr["PRate"].ToString();
                    txtMkm.Text = dr["MaxKm"].ToString();
                    txtMhrs.Text = dr["MaxHrs"].ToString();
                    txtKrate.Text = dr["exKmRate"].ToString();
                    txtHrate.Text = dr["exHrRate"].ToString();
                    txtNRateD.Text = dr["drNightRate"].ToString();
                    txtNRateV.Text = dr["vehicleNightRate"].ToString();


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

        private void Package_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayuboDataSet3.Package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.ayuboDataSet3.Package);
            fillcombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string add;
                con.Open();
                add = "insert into Package(Pid,Pname,Vtype,PRate,maxKm,maxHrs,exKmRate,exHrRate,drNightRate,vehicleNightRate) values ('" + cmbPid.Text + "' ,'" + txtPname.Text + "','" + txtVtype.Text + "','" + txtPrate.Text + "','" + txtMkm.Text + "','" + txtMhrs.Text + "','" + txtKrate.Text + "','" + txtHrate.Text + "','" + txtNRateD.Text + "','" + txtNRateV.Text + "')";
                SqlCommand cmd = new SqlCommand(add, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added successfully");
                con.Close();
                fillcombo();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string edit;
                edit = "update Package set Pname='" + txtPname.Text + "',VType='" + txtVtype.Text + "',PRate='" + txtPrate.Text + "',maxKm='" + txtMkm.Text + "',maxHrs='" + txtMhrs.Text + "',exKmRate='" + txtKrate.Text + "',exHrRate='" + txtHrate.Text + "',drNightRate='" + txtNRateD.Text + "',vehicleNightRate='" + txtNRateV.Text + "' where Pid='"+cmbPid.Text+ "' " ;
                SqlCommand cmd = new SqlCommand(edit,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully record added");
                con.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete;
            delete = "delete from Package where Pid='" + cmbPid.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
            }
            else
            {
                MessageBox.Show("Record not deleted");
            }
            con.Close();
            fillcombo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPname.Clear();
            txtVtype.Clear();
            txtPrate.Clear();
            txtMkm.Clear();
            txtMhrs.Clear();
            txtKrate.Clear();
            txtHrate.Clear();
            txtNRateD.Clear();
            txtNRateV.Clear();
        }
        }
    }

