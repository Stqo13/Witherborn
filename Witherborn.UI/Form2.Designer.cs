﻿using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form2
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
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(773, 69);
            label1.Name = "label1";
            label1.Size = new Size(327, 54);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkCyan;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(348, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1163, 483);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Item Properties";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(702, 420);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 9;
            label5.Text = "Result";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(702, 237);
            button2.Name = "button2";
            button2.Size = new Size(229, 58);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(270, 237);
            button1.Name = "button1";
            button1.Size = new Size(229, 58);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(850, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 38);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(850, 79);
            label4.Name = "label4";
            label4.Size = new Size(246, 32);
            label4.TabIndex = 4;
            label4.Text = "Enter Item Power";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 38);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 79);
            label3.Name = "label3";
            label3.Size = new Size(240, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 79);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 1;
            label2.Text = "Choose Item Type";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Armor", "Equipement", "Sword", "Wand", "Bow", "Mining Tool", "Foraging Tool", "Farming Tool", "Pet", "Minion Upgrade", "Pet Item" });
            comboBox1.Location = new Point(32, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(281, 39);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}