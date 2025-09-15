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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=True;TrustServerCertificate=True");
            cmd = new SqlCommand("select Deptno,Dname,Location from Dept", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            label2.Text = dr.GetName(0) + ": ";
            label3.Text = dr.GetName(1) + ": ";
            label4.Text = dr.GetName(2) + ": ";
            showData();


        }
        private void showData()
        {
            if (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(2).ToString();

            }
            else
            {
                MessageBox.Show("Last Record in table no data after this data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            this.Close();
        }
    }
}
