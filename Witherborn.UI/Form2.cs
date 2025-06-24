using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Witherborn.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var itemType = comboBox1.Text;
            var itemName = textBox1.Text;
            var itemPower = textBox2.Text;

            string[] input = new string[]
            {
                itemName,
                itemType,
                itemPower
            };

            await itemController.ItemOperations("Add", input);

            label5.Text = "Successfully added a new item!";

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Show();
        }
    }
}
