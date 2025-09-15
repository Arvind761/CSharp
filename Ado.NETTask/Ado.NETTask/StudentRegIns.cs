using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Ado.NETTask
{
    public partial class StudentRegIns : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public StudentRegIns()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void StudentRegIns_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=True; TrustServerCertificate=True");


        }
        private void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {//
            con.Open();
            cmd = new SqlCommand("SpInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@stdname", textBox2.Text);
            cmd.Parameters.AddWithValue("@stdlname", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox4.Text);
            cmd.Parameters.AddWithValue("@stdphone", textBox5.Text);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
            clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SpDelete", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
            clear();

            //delete
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();

            }
            this.Close();
        }
    }
}
