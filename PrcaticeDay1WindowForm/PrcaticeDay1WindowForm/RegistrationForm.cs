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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str;
            if (rdBtnMale.Checked) {
                str = "Male";

            }
            else
            {
                str = "Female";

            }
           string msg = $"Employee ID={txtID.Text}\n Employee Name: {txtName.Text}\n Employee Salary: {txtSalary.Text}\n Gender: {str}";
           MessageBox.Show(msg);
            lblAll.Text = msg;


        }
    }
}
