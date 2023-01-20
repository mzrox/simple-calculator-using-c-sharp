using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";
 
            }
            else 
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float sum = n1 + n2;
                ans.Text = "Sum = " + sum.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float subs = n1 - n2;
                ans.Text = "Substraction = " + subs.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float mul = n1 * n2;
                ans.Text = "Multiplication = " + mul.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else if(num2.Text == "0")
            {
                ans.Text = "Mathematical Error!"; 
            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float div = n1 / n2;
                ans.Text = "Division = " + div.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";
            }
            else if (num2.Text == "0")
            {
                ans.Text = "Mathematical Error!";
            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float rem = n1 % n2;
                ans.Text = "Remainder = " + rem.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float n1s = n1 * n1;
                float n2s = n2 * n2;
                ans.Text = "Num1: " + n1s.ToString() + "\nNum2: " + n2s.ToString();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float n1c = n1 * n1 * n1;
                float n2c = n2 * n2 * n2;
                ans.Text = "Num1: " + n1c.ToString() + "\nNum2: " + n2c.ToString();
            }
        }

        private void ans_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                ans.Text = "Both Inputs are Required To Run!";

            }
            else
            {
                float n1 = Int32.Parse(num1.Text);
                float n2 = Int32.Parse(num2.Text);
                float n1e = 1;
                for(int i=0; i < n2; i++)
                {
                    n1e *= n1;
                }
                ans.Text = "Exponentiation: " + n1e.ToString();
            }
        }
    }
}
