using System.Threading.Tasks;

namespace Witherborn.UI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var count = int.Parse(textBox2.Text);

            var players = await queryController.GetTopPlayersByUniqueItems(count);

            if (String.IsNullOrEmpty(players))
            {
                textBox1.Text = "Nothing to show!";
            }
            else
            {
                textBox1.Text = players;
            }

            textBox2.Text = "";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var stats = await queryController.GetPlayerOverallStats();

            if (String.IsNullOrEmpty(stats))
            {
                textBox3.Text = "Nothing to show!";
            }
            else
            {
                textBox3.Text = stats;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int level = int.Parse(textBox4.Text);

            var players = await queryController.GetPlayersByMinCatacombsLevel(level);

            if (String.IsNullOrEmpty(players))
            {
                textBox5.Text = "Nothing to show!";
            }
            else
            {
                textBox5.Text = players;
            }

            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Show();
        }
    }
}
