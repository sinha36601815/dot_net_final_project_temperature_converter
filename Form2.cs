using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace temperature_converter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox1.Text);
            result = Math.Round(number * 1000);
            label5.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox2.Text);
            result = Math.Round(number / 1000);
            label6.Text = result.ToString();
        }
    }
}
