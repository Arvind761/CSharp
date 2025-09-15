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
   
    public partial class Emp : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Emp()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=True;");
            cmd = new SqlCommand($"Insert into Emp (emp_id,emp_name,emp_sal) values({textBox1.Text},'{textBox2.Text}',{textBox3.Text})",conn);
            conn.Open();
            int a=cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("data Not inserted");
            }
            //string str=$"{textBox1.Text},'{textBox2.Text}',{textBox3.Text}"
        }
    }
}
