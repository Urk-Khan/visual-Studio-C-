using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class interest : Form
    {
        int amountIn;
        int interestIn;
        double year;
        int result;
        public interest()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
                amountIn = Convert.ToInt32(txtAmount.Text);
                interestIn = Convert.ToInt32(txtInterest.Text);
                year = Convert.ToInt32(numYear.Value);

                for (int i = 1; i <= year; i++)
                {
                    result = (amountIn * interestIn) / 100;
                    amountIn = amountIn + result;
                    txtResult.Text = amountIn.ToString();
                }
        }
    }
}
