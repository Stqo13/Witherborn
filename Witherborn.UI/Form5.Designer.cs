using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form5
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(846, 115);
            label1.Name = "label1";
            label1.Size = new Size(279, 42);
            label1.TabIndex = 0;
            label1.Text = "Player Queries";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkCyan;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(272, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1507, 624);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Queries";
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.ForeColor = Color.DarkCyan;
            button4.Location = new Point(1348, 552);
            button4.Name = "button4";
            button4.Size = new Size(137, 52);
            button4.TabIndex = 13;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightCyan;
            textBox5.ForeColor = Color.DarkCyan;
            textBox5.Location = new Point(874, 234);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Vertical;
            textBox5.Size = new Size(390, 311);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightCyan;
            textBox4.ForeColor = Color.DarkCyan;
            textBox4.Location = new Point(1203, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(61, 35);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(874, 120);
            label6.Name = "label6";
            label6.Size = new Size(323, 29);
            label6.TabIndex = 10;
            label6.Text = "Enter Number (Cata Level)";
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.ForeColor = Color.DarkCyan;
            button3.Location = new Point(874, 168);
            button3.Name = "button3";
            button3.Size = new Size(220, 49);
            button3.TabIndex = 9;
            button3.Text = "Show Players";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(874, 74);
            label5.Name = "label5";
            label5.Size = new Size(440, 29);
            label5.TabIndex = 8;
            label5.Text = "Get Players By Min Catacombs Level";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightCyan;
            textBox3.ForeColor = Color.DarkCyan;
            textBox3.Location = new Point(478, 234);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(334, 311);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(478, 129);
            button2.Name = "button2";
            button2.Size = new Size(178, 41);
            button2.TabIndex = 6;
            button2.Text = "Show Stats";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 74);
            label4.Name = "label4";
            label4.Size = new Size(291, 29);
            label4.TabIndex = 5;
            label4.Text = "Get Player Overall Stats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(322, 29);
            label3.TabIndex = 4;
            label3.Text = "Enter Number (Top Count)";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.ForeColor = Color.DarkCyan;
            textBox2.Location = new Point(352, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 35);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(28, 168);
            button1.Name = "button1";
            button1.Size = new Size(244, 49);
            button1.TabIndex = 2;
            button1.Text = "Show Top Players";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.ForeColor = Color.DarkCyan;
            textBox1.Location = new Point(28, 234);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(361, 311);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(385, 29);
            label2.TabIndex = 0;
            label2.Text = "Get Top Player By Unique Items";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(23F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1924, 1061);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Margin = new Padding(10, 8, 10, 8);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Button button3;
        private Button button4;
    }
}