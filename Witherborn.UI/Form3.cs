using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Witherborn.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var itemId = textBox1.Text;
            var itemNewName = textBox2.Text;

            var itemOldName = await context.Items
                .Where(i => i.Id == int.Parse(itemId))
                .Select(i => i.Name)
                .FirstOrDefaultAsync();

            string[] input = new string[]
            {
                itemId,
                itemNewName
            };

            await itemController.ItemOperations("Edit", input);

            textBox1.Text = "";
            textBox2.Text = "";

            label4.Text = $"Item {itemOldName} \nhas now been changed to {itemNewName}!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Show();
        }
    }
}
