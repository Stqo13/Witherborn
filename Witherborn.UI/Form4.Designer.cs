using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form4
    {
        #region DbContext
        private static readonly WitherbornDbContext context = new WitherbornDbContext();
        #endregion

        #region Services
        private static readonly IItemService itemService = new ItemService(context);
        private static readonly IQueryService queryService = new QueryService(context);
        #endregion

        #region Controllers
        private static readonly ItemController itemController = new ItemController(itemService);
        private static readonly QueryController queryController = new QueryController(queryService);
        #endregion

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Enemies = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            Enemies.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(786, 64);
            label1.Name = "label1";
            label1.Size = new Size(327, 42);
            label1.TabIndex = 0;
            label1.Text = "Dunqeon Queries";
            label1.Click += label1_Click;
            // 
            // Enemies
            // 
            Enemies.Controls.Add(textBox2);
            Enemies.Controls.Add(textBox1);
            Enemies.Controls.Add(button3);
            Enemies.Controls.Add(button2);
            Enemies.Controls.Add(label3);
            Enemies.Controls.Add(button1);
            Enemies.Controls.Add(label2);
            Enemies.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Enemies.ForeColor = Color.White;
            Enemies.Location = new Point(340, 200);
            Enemies.Name = "Enemies";
            Enemies.Size = new Size(1186, 552);
            Enemies.TabIndex = 1;
            Enemies.TabStop = false;
            Enemies.Text = "Dungeon queries";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.ForeColor = Color.DarkCyan;
            textBox2.Location = new Point(513, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(348, 281);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.ForeColor = Color.DarkCyan;
            textBox1.Location = new Point(37, 214);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(361, 281);
            textBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.ForeColor = Color.DarkCyan;
            button3.Location = new Point(1006, 458);
            button3.Name = "button3";
            button3.Size = new Size(160, 51);
            button3.TabIndex = 6;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(513, 127);
            button2.Name = "button2";
            button2.Size = new Size(219, 54);
            button2.TabIndex = 4;
            button2.Text = "Show Count";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 79);
            label3.Name = "label3";
            label3.Size = new Size(322, 29);
            label3.TabIndex = 3;
            label3.Text = "Get Dungeon Player Count";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(37, 127);
            button1.Name = "button1";
            button1.Size = new Size(219, 54);
            button1.TabIndex = 1;
            button1.Text = "Show Enemies";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 79);
            label2.Name = "label2";
            label2.Size = new Size(389, 29);
            label2.TabIndex = 0;
            label2.Text = "Get Dungeon's Strongest Enemy";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Enemies);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Form4";
            Enemies.ResumeLayout(false);
            Enemies.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox Enemies;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}