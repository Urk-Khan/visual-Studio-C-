using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue;
        String opreationPerform = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOperationPerformed))
            {
                textBox.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }

        private void clickOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            opreationPerform = button.Text;
            resultValue = Double.Parse(textBox.Text);
            lblResult.Text = resultValue + " " + opreationPerform;
            isOperationPerformed = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
            lblResult.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (opreationPerform)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
            }
        }
    }
}
