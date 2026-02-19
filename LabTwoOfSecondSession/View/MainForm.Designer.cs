using System;
using System.Windows.Forms;

namespace LabTwoOfSecondSession
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnForParse = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            intValueReturn = new TextBox();
            Enums = new TabControl();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            Enums.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(864, 596);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnForParse);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(3, 392);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 196);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(16, 129);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 9;
            label5.Text = "Напишите день недели";
            // 
            // btnForParse
            // 
            btnForParse.Location = new Point(374, 79);
            btnForParse.Name = "btnForParse";
            btnForParse.Size = new Size(131, 34);
            btnForParse.TabIndex = 8;
            btnForParse.Text = "Parse";
            btnForParse.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 79);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 34);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 39);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 6;
            label4.Text = "Type value for parsing";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(intValueReturn);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 383);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumeration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 38);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Int Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 38);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Choose Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose Enumeration";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(257, 61);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(200, 304);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValueListBox_Changed;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(16, 61);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(207, 304);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_Changed;
            // 
            // intValueReturn
            // 
            intValueReturn.Location = new Point(508, 61);
            intValueReturn.Multiline = true;
            intValueReturn.Name = "intValueReturn";
            intValueReturn.Size = new Size(184, 34);
            intValueReturn.TabIndex = 2;
            // 
            // Enums
            // 
            Enums.Controls.Add(tabPage1);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(872, 629);
            Enums.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 629);
            Controls.Add(Enums);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Enums.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TextBox intValueReturn;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabControl Enums;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnForParse;
        private TextBox textBox2;
        private Label label4;
    }
}