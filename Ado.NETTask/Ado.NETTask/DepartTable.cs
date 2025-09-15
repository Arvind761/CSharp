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
    public partial class DepartTable : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public DepartTable()
        {
            InitializeComponent();
        }



        private void DepartTable_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=True");
            //conn.ConnectionString = "Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=True";
            cmd = new SqlCommand("Select Deptno, Dname, Location From Dept Order By Deptno", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            label1.Text = dr.GetName(0) + ": ";
            label2.Text = dr.GetName(1) + ": ";
            label3.Text = dr.GetName(2) + ": ";
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
                MessageBox.Show("You are at the last record of table.", "Information", MessageBoxButtons.OK,
MessageBoxIcon.Information);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();

            }
            this.Close();   

        }
    }
}
