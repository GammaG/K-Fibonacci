using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_Fibonacci
{
    public partial class Form1 : Form
    {
        private int k;
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                k = (int)numericUpDown1.Value;
                n = (int)numericUpDown2.Value;

                if (checkBox1.Checked)
                {
                    cleanResultTextBox();
                    cleanValueTextbox();
                }

                if (n <= 0 | k <= 0)
                {
                    throw new ArgumentException("Your input wasn't valid.");
                }
               
                generate();
            }
            catch (Exception ex)
            {
                appendResultTextBox(ex.Message);
            }
        }

        private void generate()
        {
            Fibonacci fb = new Fibonacci(k);
            appendValueTextbox(k + " " + n +"\t");
            for (int i = 0; i <= n; i++)
            {
                appendValueTextbox("");
            }
            appendValueTextbox("___________");
            appendResultTextBox("\tn\tkBonacci(" + k + " ,n)");
            appendResultTextBox("________________________________________");
            for (int i = 0; i <= n; i++)
            {
                long result = fb.fib(i);
                appendResultTextBox("\t" + i + "\t" + result);
            }
            appendResultTextBox("________________________________________");
        }


        private void appendValueTextbox(String text)
        {
            valueTextbox.AppendText(text + "\r\n");
        }

        private void cleanValueTextbox()
        {
            valueTextbox.Clear();
        }
        private void appendResultTextBox(String text)
        {
            resultTextBox.AppendText(text + "\r\n");
        }

        private void cleanResultTextBox()
        {
            resultTextBox.Clear();
        }
    }
}
