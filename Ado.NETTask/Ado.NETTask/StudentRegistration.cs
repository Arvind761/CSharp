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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Ado.NETTask
{

    public partial class StudentRegistration : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public StudentRegistration()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            //string gender = radioButton1.Text;
            string gender="";
            string lang = checkBox1.Text;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                lang = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = false;
                lang = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                lang = checkBox3.Text;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = true;
            }


            cmd = new SqlCommand($"insert into Student_Registration(stu_id,stu_name,stu_gender,stu_dob,stu_phone,stu_lang) values({textBox1.Text},'{textBox2.Text}','{gender}','{textBox3.Text}','{textBox4.Text}','{lang}')", con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("data Not inserted");
            }
            button1.Enabled = false;


        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Text;
            string lang = checkBox1.Text;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            if (checkBox1.Checked)
            {

                lang = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {

                lang = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                lang = checkBox3.Text;

            }
            con.Close();
            string query = $"update Student_Registration set stu_name='{textBox2.Text}',stu_gender='{gender}',stu_dob='{textBox3.Text}',stu_phone='{textBox4.Text}',stu_lang='{lang}' where stu_id={textBox1.Text}";
            cmd = new SqlCommand(query, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("data Updated");
            }
            else
            {
                MessageBox.Show("data Not Upadated");
            }


        }

        private void StudentRegistration_Load_1(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=CSDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Close();
            string query = $"Delete from Student_Registration  where stu_id={textBox1.Text}";
            cmd = new SqlCommand(query, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("data Deleted");
            }
            else
            {
                MessageBox.Show("data Not Deleted");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
            button1.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            string query = $"select * from Student_Registration where stu_id={textBox1.Text}";
            cmd=new SqlCommand(query, con);
            con.Open();
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["stu_name"].ToString();
                textBox3.Text = dr["stu_dob"].ToString();
                textBox4.Text = dr["stu_phone"].ToString();
                string gen = dr["stu_gender"].ToString();
                string lang = dr["stu_lang"].ToString();
                gen.TrimEnd();
                
                if (gen == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
               
                if (lang == checkBox1.Text)
                {
                    checkBox1.Checked = true;
                }
                else if (lang == checkBox2.Text)
                {
                    checkBox2.Checked = true;
                }
                else if (lang == checkBox3.Text)
                {
                    checkBox3.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("Last Data of the table");
            }
            con.Close();
            


        }
    }
}
