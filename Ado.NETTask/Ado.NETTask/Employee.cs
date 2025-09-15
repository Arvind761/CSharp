using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ado.NETTask
{

    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB; Integrated Security=SSPI;TrustServerCertificate=True");
            //cmd = new SqlCommand("Select Eno,Ename,Job,Salary,Status from Employee order by Eno", con);
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            loadData();
        }
        private void loadData()
        {
            cmd.CommandText = "select Eno,Ename,Job,Salary,Status from Employee order by Eno";
            dr = cmd.ExecuteReader();
            showData();

        }
        private void showData()
        {
            if (dr.Read())
            {
                textBox1.Text = dr["Eno"].ToString();
                textBox2.Text = dr["Ename"].ToString();
                textBox3.Text = dr["Job"].ToString();
                textBox4.Text = dr["Salary"].ToString();
                checkBox1.Checked = (bool)dr["Status"];

            }
            else
            {
                MessageBox.Show("No data Available in table or Reached Last record of the table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            btnInsert.Enabled = true;
            checkBox1.Checked = false;

            
        }
    }
}
