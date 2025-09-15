namespace PrcaticeDay1WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Yellow;
        }

      
    }
}

