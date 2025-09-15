using System.Data.Odbc;
//using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
namespace Ado.NETTask
{
    public partial class Form1 : Form
    {
        OdbcConnection conn;
        OleDbConnection conOle;

        SqlConnection conSql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bnOdbc_Click(object sender, EventArgs e)
        {
            conn = new OdbcConnection("Dsn=SqlDsn");
            conn.Open();
            MessageBox.Show("connection State:" + conn.State);
            conn.Close();
            MessageBox.Show("connection State:" + conn.State);



        }

        private void btnOLEDB_Click(object sender, EventArgs e)
        {
            //Sql Connetions
            conSql = new SqlConnection();
            conSql.ConnectionString = "Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=Master;Integrated Security=SSPI";
            conSql.Open();
            MessageBox.Show("connection State:" + conSql.State);
            conSql.Close();
            MessageBox.Show("connection State:" + conSql.State);

        }

        private void btOledb_Click(object sender, EventArgs e)
        {
            try
            {
                conOle = new OleDbConnection();
                conOle.ConnectionString = "Provider=SqlOledb;Data Source=DESKTOP-H468LH3\\SQLEXPRESS;Database=Master;Integrated Security=SSPI;";
                conOle.Open();
                MessageBox.Show("connection State:" + conOle.State);
                conOle.Close();
                MessageBox.Show("connection State:" + conOle.State);
            }
            catch(Exception E)
            {
                MessageBox.Show($"{E.Message}");
            }
        }
    }
}
