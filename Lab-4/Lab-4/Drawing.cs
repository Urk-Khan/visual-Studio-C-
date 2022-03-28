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
    public partial class Drawing : Form
    {
        bool clickMouse;
        public Drawing()
        {
            InitializeComponent();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            clickMouse = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            clickMouse = true;
        }

        private void panel1_Paint(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickMouse == true)
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    g.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 5, 5);
                    
                }
            }
        }
    }
}
