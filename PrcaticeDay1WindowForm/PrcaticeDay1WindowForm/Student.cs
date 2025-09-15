using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrcaticeDay1WindowForm
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Student id={txtId.Text}\n Student First Name: {txtFName.Text}\n Student Last Name: {txtLName.Text}");
        }
    }
}
