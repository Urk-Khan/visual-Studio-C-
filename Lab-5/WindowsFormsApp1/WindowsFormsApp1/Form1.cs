using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MessageBoxButtons buttonType { get; set; }
        private MessageBoxIcon iconType { get; set; }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult help = MessageBox.Show("Want to send mail", "Contact us", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(help == DialogResult.Yes)
            {

            }
            
        }
    }
}
