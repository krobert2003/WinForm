using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Nem addtál meg Nevet");
            }
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Nem addtál meg Nyelvet ");
            }
            if (String.IsNullOrEmpty(numericUpDown1.Text))
            {
                MessageBox.Show("Nem addtál Azonosítót");
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Nem addtál születési dátumott");
            }
            if (String.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Nem addtál születési helyet");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
