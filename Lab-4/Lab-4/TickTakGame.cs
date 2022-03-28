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
    public partial class TickTakGame : Form
    {
        bool check;
        bool result = false;
        public TickTakGame()
        {
            InitializeComponent();
        }
        private void funCheck()
        {

/*            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text) *//* || (btn21.Text == btn22.Text && btn22.Text == btn23.Text) || (btn31.Text == btn32.Text && btn32.Text == btn33.Text)*//*
            {
                MessageBox.Show("Hurrah Player: 1 Won");
            }
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text)
            {
                MessageBox.Show("Hurrah Player: 1 Won");
            }
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text)
            {
                MessageBox.Show("Hurrah Player: 1 Won");
            }*/

        }
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (check == true)
            {
                btn.Text = "T";
                funCheck();
            }
            else
            {
                btn.Text = "F";
                funCheck();
            }
            check =! check;
            btn.Enabled = false;
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
            if (rdTrue.Checked)
            {
                check = true;
                lblPlayer.Text = "Player: 1 =\t'T' \nPlayer: 2 =\t'F'";
            }
            else if (rdFalse.Checked)
            {
                check = false;
                lblPlayer.Text = "Player: 1 =\t'F' \nPlayer: 2 =\t'T'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
        }
    }
}
