using System;
using System.Windows.Forms;

namespace Exp_Handeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num_Button = new System.Windows.Forms.Button();
            this.String_Button = new System.Windows.Forms.Button();
            this.Tom_Text = new System.Windows.Forms.TextBox();
            this.Tom_Button = new System.Windows.Forms.Button();
            this.String_Text = new System.Windows.Forms.TextBox();
            this.Numbers_Test = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Num_Button
            // 
            this.Num_Button.Location = new System.Drawing.Point(284, 48);
            this.Num_Button.Name = "Num_Button";
            this.Num_Button.Size = new System.Drawing.Size(102, 23);
            this.Num_Button.TabIndex = 0;
            this.Num_Button.Text = "Enter Number";
            this.Num_Button.UseVisualStyleBackColor = true;
            this.Num_Button.Click += new System.EventHandler(this.Num_Button_Click);
            // 
            // String_Button
            // 
            this.String_Button.Location = new System.Drawing.Point(284, 107);
            this.String_Button.Name = "String_Button";
            this.String_Button.Size = new System.Drawing.Size(102, 23);
            this.String_Button.TabIndex = 2;
            this.String_Button.Text = "Enter String";
            this.String_Button.UseVisualStyleBackColor = true;
            this.String_Button.Click += new System.EventHandler(this.String_Button_Click);
            // 
            // Tom_Text
            // 
            this.Tom_Text.Location = new System.Drawing.Point(66, 170);
            this.Tom_Text.Name = "Tom_Text";
            this.Tom_Text.Size = new System.Drawing.Size(100, 20);
            this.Tom_Text.TabIndex = 4;
            // 
            // Tom_Button
            // 
            this.Tom_Button.Location = new System.Drawing.Point(284, 170);
            this.Tom_Button.Name = "Tom_Button";
            this.Tom_Button.Size = new System.Drawing.Size(102, 23);
            this.Tom_Button.TabIndex = 5;
            this.Tom_Button.Text = "Enter \"Tom\"";
            this.Tom_Button.UseVisualStyleBackColor = true;
            this.Tom_Button.Click += new System.EventHandler(this.Tom_Button_Click);
            // 
            // String_Text
            // 
            this.String_Text.Location = new System.Drawing.Point(66, 110);
            this.String_Text.Name = "String_Text";
            this.String_Text.Size = new System.Drawing.Size(100, 20);
            this.String_Text.TabIndex = 6;
            // 
            // Numbers_Test
            // 
            this.Numbers_Test.Location = new System.Drawing.Point(66, 51);
            this.Numbers_Test.Name = "Numbers_Test";
            this.Numbers_Test.Size = new System.Drawing.Size(100, 20);
            this.Numbers_Test.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.Numbers_Test);
            this.Controls.Add(this.String_Text);
            this.Controls.Add(this.Tom_Button);
            this.Controls.Add(this.Tom_Text);
            this.Controls.Add(this.String_Button);
            this.Controls.Add(this.Num_Button);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox Numbers_Test;
        private System.Windows.Forms.TextBox String_Text;
        private System.Windows.Forms.Button String_Button;
        private System.Windows.Forms.TextBox Tom_Text;
        private System.Windows.Forms.Button Tom_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Num_Button;

        private void Num_Button_Click(object sender, EventArgs e)
        {
            int r;
            string str = Numbers_Test.Text;

            try
            {
                r = int.Parse(str); 
                MessageBox.Show("This is a valid Number");
            }
            catch
            {
                 MessageBox.Show("This is not a valid Number");
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Console.Write("Hello");
        }

        private void String_Button_Click(object sender, EventArgs e)
        {
            int r;
            string str = String_Text.Text;

            if (int.TryParse(str, out r))
            {
                MessageBox.Show("This is not a valid String");
            }
            else
            {
                MessageBox.Show("This is a valid String");
            }
        }

        private void Tom_Button_Click(object sender, EventArgs e)
        {
            string text = Tom_Text.Text;

            if (text == "Tom")
            {
                MessageBox.Show("That is correct!");
            }
            else
            {
                MessageBox.Show("Check your spelling and capitalation");
            }
        }
    }
}