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
    public partial class ExamCrud : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public ExamCrud()
        {
            InitializeComponent();
        }


        private void ExamCrud_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=SQLEXAM;Integrated Security=true;TrustServerCertificate=True;");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            string lang = "";

            if (checkBox1.Checked)
            {
                lang = "Hindi";
            }
            if (checkBox2.Checked)
            {
                lang = "English";
            }
            if (checkBox3.Checked)
            {
                lang = "Marathi";

            }
            string combox = comboBox1.SelectedItem.ToString();
            string query = $"Insert into Student_Exam(StdId,StdName,Fee,Gender,Course,Language,PhNumber,Email) values({txtID.Text},'{txtName.Text}',{txtFee.Text},'{gender}','{combox}','{lang}','{txtPhone.Text}','{txtEmail.Text}')";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                MessageBox.Show("Data inserted");
            }
            else
            {
                MessageBox.Show(" Data not inserted");
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string query = $"Delete from Student_Exam where StdId={txtID.Text}";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                MessageBox.Show("Data Deleted");
            }
            else
            {
                MessageBox.Show(" Data not Deleted");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=SQLEXAM;Integrated Security=true;TrustServerCertificate=True;");
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            string lang = "";

            if (checkBox1.Checked)
            {
                lang = "Hindi";
            }
            if (checkBox2.Checked)
            {
                lang = "English";
            }
            if (checkBox3.Checked)
            {
                lang = "Marathi";

            }
            string combox = comboBox1.SelectedItem.ToString();
            string query = $"update Student_Exam set StdId={txtID.Text},StdName='{txtName.Text}',Fee={txtFee.Text},Gender='{gender}',Course='{combox}',Language='{lang}',PhNumber='{txtPhone.Text}',Email='{txtEmail.Text}' where StdId={txtID.Text}";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                MessageBox.Show("Data updated");
            }
            else
            {
                MessageBox.Show(" Data not updated");
            }

        }
    }
}
