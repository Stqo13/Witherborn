using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form3
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
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(806, 79);
            label1.Name = "label1";
            label1.Size = new Size(357, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit Item Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(407, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 422);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose an item to change";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(564, 277);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 6;
            label4.Text = "Result";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(838, 63);
            button2.Name = "button2";
            button2.Size = new Size(218, 57);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(564, 62);
            button1.Name = "button1";
            button1.Size = new Size(218, 58);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 38);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 277);
            label3.Name = "label3";
            label3.Size = new Size(307, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter New Item Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 38);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 76);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 0;
            label2.Text = "Enter Item Id";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}