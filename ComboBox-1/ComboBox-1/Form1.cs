using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected" + " " + comboBox3.Text + " " + comboBox2.Text + " " + comboBox1.Text + "....MessageBox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int LastYear = 2028;
            for (int i = 2008; i <= LastYear; i++)
            {
                comboBox1.Items.Add(i);
            }

            List<comboBox2> list = new List<comboBox2>();
            list.Add(new comboBox2() { Number = 0, Name = "       " });
            list.Add(new comboBox2() { Number = 1, Name = "January" });
            list.Add(new comboBox2() { Number = 2, Name = "February" });
            list.Add(new comboBox2() { Number = 3, Name = "March" });
            list.Add(new comboBox2() { Number = 4, Name = "April" });
            list.Add(new comboBox2() { Number = 5, Name = "May" });
            list.Add(new comboBox2() { Number = 6, Name = "June" });
            list.Add(new comboBox2() { Number = 7, Name = "July" });
            list.Add(new comboBox2() { Number = 8, Name = "August" });
            list.Add(new comboBox2() { Number = 9, Name = "September" });
            list.Add(new comboBox2() { Number = 10, Name = "October" });
            list.Add(new comboBox2() { Number = 11, Name = "November" });
            list.Add(new comboBox2() { Number = 12, Name = "December" });
            comboBox2.DataSource = list;
            comboBox2.ValueMember = "Number";
            comboBox2.DisplayMember = "Name";

            int days = 31;
            for (int i = 1; i <= days; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = comboBox3.Text + ' ' + comboBox2.Text + ' ' + comboBox1.Text;
        }
    }
}
