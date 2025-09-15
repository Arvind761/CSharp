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
    public partial class ListBoxPlaceAdd : Form
    {
        public ListBoxPlaceAdd()
        {
            InitializeComponent();
        }

        private void ListBoxPlaceAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] str = new string[listBox1.Items.Count];
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    str[i]=listBox1.Items[i].ToString();
            //}

            foreach(var i in listBox1.Items)

            {
                listBox2.Items.Add(i);
            }
            listBox1.Items.Clear();
            //foreach (var item in listBox2.Items)
            //{
            //    listBox1.Items.Add(item);
            //}
            //listBox1.Items.Clear();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var i in listBox2.Items)

            {
                listBox1.Items.Add(i);
            }
            listBox2.Items.Clear();

        }
    }
}
