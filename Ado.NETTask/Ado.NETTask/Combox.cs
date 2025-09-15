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
    public partial class Combox : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Combox()
        {
            InitializeComponent();
        }

        private void Combox_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=True;TrustServerCertificate=True;");
            cmd = new SqlCommand("select E_id,E_name,E_desg,E_sal from Employee_combo", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(Convert.ToInt32(dr["E_id"]));


            }
            conn.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(comboBox1.SelectedText);
            cmd = new SqlCommand($"select E_name,E_desg,E_sal from Employee_combo where E_id={comboBox1.Text}", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            //comboBox1.Text = dr["E_id"].ToString();
            if (dr.Read())
            {
                textBox1.Text = Convert.ToString(dr["E_name"]);
                textBox2.Text = Convert.ToString(dr["E_desg"]);
                textBox3.Text = dr["E_sal"].ToString();
            }
            conn.Close();



        }
    }
}
