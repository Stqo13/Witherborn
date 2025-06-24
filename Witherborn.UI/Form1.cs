namespace Witherborn.UI
{
    public partial class Form1
        : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form5 = new Form5();
            form5.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
