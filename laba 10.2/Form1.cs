using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double ch1;
        private double ch2;
        private double avg;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch1 = double.Parse(textBox1.Text);
            ch2 = double.Parse (textBox2.Text);
            avg = (ch1 + ch2)/2;
            textBox3.Text = Convert.ToString(avg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch1 = double.Parse(textBox1.Text);
            ch2 = double.Parse(textBox2.Text);
            avg = Math.Sqrt(ch1*ch2);
            textBox3.Text = Convert.ToString(avg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = null; textBox1.Text = null; textBox3.Text = null;
        }
    }
}
