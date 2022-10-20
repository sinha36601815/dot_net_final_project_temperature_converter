namespace temperature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name == "sinha" && pass == "123456789")
            {
                Form2 f1 = new Form2();
                f1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}