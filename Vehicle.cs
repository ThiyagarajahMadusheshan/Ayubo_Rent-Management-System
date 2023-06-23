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
    public partial class Vehicle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NHM6UBNJ\\SQLEXPRESS;Initial Catalog=Ayubo;Integrated Security=True");
        public Vehicle()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select RegNo from Vehicle", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbRegno.DataSource = dt;
            cmbRegno.DisplayMember = "RegNo";
            cmbRegno.ValueMember = "RegNo";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete;
            delete = "delete from vehicle where RegNo='" + cmbRegno.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String search = "select * from vehicle where RegNo ='" + cmbRegno.Text + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtVtype.Text = dr["Vtype"].ToString();
                    txtMake.Text = dr["Make"].ToString();
                    txtDrate.Text = dr["Drate"].ToString();
                    txtWrate.Text = dr["Wrate"].ToString();
                    txtMrate.Text = dr["Mrate"].ToString();
                    txtDRrate.Text = dr["DrRate"].ToString();

                }
                else
                    MessageBox.Show("Employee not found");
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayuboDataSet2.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter1.Fill(this.ayuboDataSet2.Vehicle);
            
            fillcombo();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string add;
                con.Open();
                add = "insert into Vehicle(RegNo,Vtype,Make,Drate,Wrate,Mrate,Drrate) values ('" + cmbRegno.Text + "' ,'" + txtVtype.Text + "','" + txtMake.Text + "','" + txtDrate.Text + "','" + txtWrate.Text + "','" + txtMrate.Text + "','" + txtDRrate.Text + "')";
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
                edit = "update Vehicle set VType='" + txtVtype.Text + "',Make='" + txtMake.Text + "',Drate='" + txtDrate.Text + "',Wrate='" + txtWrate.Text + "',Mrate='" + txtMrate.Text + "',DRrate='" + txtDRrate.Text + "' where RegNo='" + cmbRegno.Text + "' ";
                SqlCommand cmd = new SqlCommand(edit, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully record added");
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVtype.Clear();
            txtMake.Clear();
            txtDrate.Clear();
            txtWrate.Clear();
            txtMrate.Clear();
            txtDRrate.Clear();

        }

        private void cmbRegno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
