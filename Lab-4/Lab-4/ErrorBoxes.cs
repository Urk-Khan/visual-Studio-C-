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
    public partial class ErrorBoxes : Form
    {
        public ErrorBoxes()
        {
            InitializeComponent();
        }
        private MessageBoxButtons ButtonType { get; set; }
        private MessageBoxIcon IconType { get; set; }
        String title;
        String message;

        private void displayButton(object sender, EventArgs e)
        {
            String title = txtTitel.Text;
            String message = txtMessage.Text;
            DialogResult result = MessageBox.Show(
                title, message,
                ButtonType, IconType);
            switch (result)
            {
                case DialogResult.OK:
                    lblDisplay.Text = "Ok was pressed";
                    break;
                case DialogResult.Cancel:
                    lblDisplay.Text = "Cancel was pressed";
                    break;
                case DialogResult.Abort:
                    lblDisplay.Text = "Abort was pressed";
                    break;
                case DialogResult.No:
                    lblDisplay.Text = "No was pressed";
                    break;
                case DialogResult.Retry:
                    lblDisplay.Text = "Retry was pressed";
                    break;
                default:
                    break;
            }
        }

        private void buttonTypeCheck(object sender, EventArgs e)
        {
            if (sender == rdOk)
            {
                ButtonType = MessageBoxButtons.OK;
            }
            if (sender == rdOkCancel)
            {
                ButtonType = MessageBoxButtons.OKCancel;
            }
            if (sender == rdAborteryIgnore)
            {
                ButtonType = MessageBoxButtons.AbortRetryIgnore;
            }
            if (sender == rdYesNoCancel)
            {
                ButtonType = MessageBoxButtons.YesNoCancel;
            }
            if (sender == rdYesNo)
            {
                ButtonType = MessageBoxButtons.YesNo;
            }
            if (sender == rdRetryCancel)
            {
                ButtonType = MessageBoxButtons.RetryCancel;
            }
        }

        private void iconTypeChanged(object sender, EventArgs e)
        {
            if (sender == rdAsterisk)
            {
                IconType = MessageBoxIcon.Asterisk;
            }
            if (sender == rdError)
            {
                IconType = MessageBoxIcon.Error;
            }
            if (sender == rdExclamation)
            {
                IconType = MessageBoxIcon.Exclamation;
            }
            if (sender == rdHand)
            {
                IconType = MessageBoxIcon.Hand;
            }
            if (sender == rdInform)
            {
                IconType = MessageBoxIcon.Information;
            }
            if (sender == rdQuestion)
            {
                IconType = MessageBoxIcon.Question;
            }
            if (sender == rdStop)
            {
                IconType = MessageBoxIcon.Stop;
            }
            if (sender == rdWarning)
            {
                IconType = MessageBoxIcon.Warning;
            }
        }
    }
}
