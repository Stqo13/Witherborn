using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form1
    {
        #region DbContext
            private static readonly WitherbornDbContext context= new WitherbornDbContext();
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(673, 65);
            label1.Name = "label1";
            label1.Size = new Size(565, 104);
            label1.TabIndex = 0;
            label1.Text = "Witherborn";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(277, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1361, 455);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Command Center";
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.ForeColor = Color.DarkCyan;
            button4.Location = new Point(839, 282);
            button4.Name = "button4";
            button4.Size = new Size(306, 73);
            button4.TabIndex = 3;
            button4.Text = "2nd Query";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.ForeColor = Color.DarkCyan;
            button3.Location = new Point(839, 119);
            button3.Name = "button3";
            button3.Size = new Size(306, 73);
            button3.TabIndex = 2;
            button3.Text = "1st Query";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Lucida Handwriting", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(226, 280);
            button2.Name = "button2";
            button2.Size = new Size(306, 73);
            button2.TabIndex = 1;
            button2.Text = "Edit Item";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Handwriting", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(226, 119);
            button1.Name = "button1";
            button1.Size = new Size(306, 73);
            button1.TabIndex = 0;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "UI.Main";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
