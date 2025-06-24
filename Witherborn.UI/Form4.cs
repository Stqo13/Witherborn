using System.Threading.Tasks;

namespace Witherborn.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var enemies = await queryController.GetFloorsStrongestEnemy();

            if (String.IsNullOrWhiteSpace(enemies))
            {
                textBox1.Text = "Nothing to show!";
            }
            else
            {
                textBox1.Text = enemies;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result = await queryController.GetDungeonPlayerCounts();

            if (String.IsNullOrWhiteSpace(result))
            {
                textBox2.Text = "Nothing to show!";
            }
            else
            {
                textBox2.Text = result;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Show();
        }
    }
}
