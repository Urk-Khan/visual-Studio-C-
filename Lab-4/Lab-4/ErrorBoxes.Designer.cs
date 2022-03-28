
namespace Lab_4
{
    partial class ErrorBoxes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.rdYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rdRetryCancel = new System.Windows.Forms.RadioButton();
            this.rdOkCancel = new System.Windows.Forms.RadioButton();
            this.rdAborteryIgnore = new System.Windows.Forms.RadioButton();
            this.rdYesNo = new System.Windows.Forms.RadioButton();
            this.rdOk = new System.Windows.Forms.RadioButton();
            this.grpIcon = new System.Windows.Forms.GroupBox();
            this.rdHand = new System.Windows.Forms.RadioButton();
            this.rdQuestion = new System.Windows.Forms.RadioButton();
            this.rdError = new System.Windows.Forms.RadioButton();
            this.rdWarning = new System.Windows.Forms.RadioButton();
            this.rdStop = new System.Windows.Forms.RadioButton();
            this.rdExclamation = new System.Windows.Forms.RadioButton();
            this.rdInform = new System.Windows.Forms.RadioButton();
            this.rdAsterisk = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpButton.SuspendLayout();
            this.grpIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.rdYesNoCancel);
            this.grpButton.Controls.Add(this.rdRetryCancel);
            this.grpButton.Controls.Add(this.rdOkCancel);
            this.grpButton.Controls.Add(this.rdAborteryIgnore);
            this.grpButton.Controls.Add(this.rdYesNo);
            this.grpButton.Controls.Add(this.rdOk);
            this.grpButton.Location = new System.Drawing.Point(12, 12);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(146, 174);
            this.grpButton.TabIndex = 0;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button Type";
            // 
            // rdYesNoCancel
            // 
            this.rdYesNoCancel.AutoSize = true;
            this.rdYesNoCancel.Location = new System.Drawing.Point(6, 100);
            this.rdYesNoCancel.Name = "rdYesNoCancel";
            this.rdYesNoCancel.Size = new System.Drawing.Size(110, 17);
            this.rdYesNoCancel.TabIndex = 1;
            this.rdYesNoCancel.TabStop = true;
            this.rdYesNoCancel.Text = "YES NO CANCEL";
            this.rdYesNoCancel.UseVisualStyleBackColor = true;
            this.rdYesNoCancel.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // rdRetryCancel
            // 
            this.rdRetryCancel.AutoSize = true;
            this.rdRetryCancel.Location = new System.Drawing.Point(6, 146);
            this.rdRetryCancel.Name = "rdRetryCancel";
            this.rdRetryCancel.Size = new System.Drawing.Size(107, 17);
            this.rdRetryCancel.TabIndex = 1;
            this.rdRetryCancel.TabStop = true;
            this.rdRetryCancel.Text = "RETRY CANCEL";
            this.rdRetryCancel.UseVisualStyleBackColor = true;
            this.rdRetryCancel.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // rdOkCancel
            // 
            this.rdOkCancel.AutoSize = true;
            this.rdOkCancel.Location = new System.Drawing.Point(6, 54);
            this.rdOkCancel.Name = "rdOkCancel";
            this.rdOkCancel.Size = new System.Drawing.Size(85, 17);
            this.rdOkCancel.TabIndex = 1;
            this.rdOkCancel.TabStop = true;
            this.rdOkCancel.Text = "OK CANCEL";
            this.rdOkCancel.UseVisualStyleBackColor = true;
            this.rdOkCancel.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // rdAborteryIgnore
            // 
            this.rdAborteryIgnore.AutoSize = true;
            this.rdAborteryIgnore.Location = new System.Drawing.Point(6, 77);
            this.rdAborteryIgnore.Name = "rdAborteryIgnore";
            this.rdAborteryIgnore.Size = new System.Drawing.Size(139, 17);
            this.rdAborteryIgnore.TabIndex = 0;
            this.rdAborteryIgnore.TabStop = true;
            this.rdAborteryIgnore.Text = "ABORTRETY_IGNORE";
            this.rdAborteryIgnore.UseVisualStyleBackColor = true;
            this.rdAborteryIgnore.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // rdYesNo
            // 
            this.rdYesNo.AutoSize = true;
            this.rdYesNo.Location = new System.Drawing.Point(6, 123);
            this.rdYesNo.Name = "rdYesNo";
            this.rdYesNo.Size = new System.Drawing.Size(65, 17);
            this.rdYesNo.TabIndex = 0;
            this.rdYesNo.TabStop = true;
            this.rdYesNo.Text = "YES NO";
            this.rdYesNo.UseVisualStyleBackColor = true;
            this.rdYesNo.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // rdOk
            // 
            this.rdOk.AutoSize = true;
            this.rdOk.Location = new System.Drawing.Point(6, 31);
            this.rdOk.Name = "rdOk";
            this.rdOk.Size = new System.Drawing.Size(40, 17);
            this.rdOk.TabIndex = 0;
            this.rdOk.TabStop = true;
            this.rdOk.Text = "OK";
            this.rdOk.UseVisualStyleBackColor = true;
            this.rdOk.CheckedChanged += new System.EventHandler(this.buttonTypeCheck);
            // 
            // grpIcon
            // 
            this.grpIcon.Controls.Add(this.rdHand);
            this.grpIcon.Controls.Add(this.rdQuestion);
            this.grpIcon.Controls.Add(this.rdError);
            this.grpIcon.Controls.Add(this.rdWarning);
            this.grpIcon.Controls.Add(this.rdStop);
            this.grpIcon.Controls.Add(this.rdExclamation);
            this.grpIcon.Controls.Add(this.rdInform);
            this.grpIcon.Controls.Add(this.rdAsterisk);
            this.grpIcon.Location = new System.Drawing.Point(176, 12);
            this.grpIcon.Name = "grpIcon";
            this.grpIcon.Size = new System.Drawing.Size(146, 224);
            this.grpIcon.TabIndex = 2;
            this.grpIcon.TabStop = false;
            this.grpIcon.Text = "Icon Type";
            // 
            // rdHand
            // 
            this.rdHand.AutoSize = true;
            this.rdHand.Location = new System.Drawing.Point(6, 100);
            this.rdHand.Name = "rdHand";
            this.rdHand.Size = new System.Drawing.Size(56, 17);
            this.rdHand.TabIndex = 1;
            this.rdHand.TabStop = true;
            this.rdHand.Text = "HAND";
            this.rdHand.UseVisualStyleBackColor = true;
            this.rdHand.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdQuestion
            // 
            this.rdQuestion.AutoSize = true;
            this.rdQuestion.Location = new System.Drawing.Point(6, 146);
            this.rdQuestion.Name = "rdQuestion";
            this.rdQuestion.Size = new System.Drawing.Size(81, 17);
            this.rdQuestion.TabIndex = 1;
            this.rdQuestion.TabStop = true;
            this.rdQuestion.Text = "QUESTION";
            this.rdQuestion.UseVisualStyleBackColor = true;
            this.rdQuestion.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdError
            // 
            this.rdError.AutoSize = true;
            this.rdError.Location = new System.Drawing.Point(6, 54);
            this.rdError.Name = "rdError";
            this.rdError.Size = new System.Drawing.Size(64, 17);
            this.rdError.TabIndex = 1;
            this.rdError.TabStop = true;
            this.rdError.Text = "ERROR";
            this.rdError.UseVisualStyleBackColor = true;
            this.rdError.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdWarning
            // 
            this.rdWarning.AutoSize = true;
            this.rdWarning.Location = new System.Drawing.Point(6, 192);
            this.rdWarning.Name = "rdWarning";
            this.rdWarning.Size = new System.Drawing.Size(78, 17);
            this.rdWarning.TabIndex = 0;
            this.rdWarning.TabStop = true;
            this.rdWarning.Text = "WARNING";
            this.rdWarning.UseVisualStyleBackColor = true;
            this.rdWarning.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdStop
            // 
            this.rdStop.AutoSize = true;
            this.rdStop.Location = new System.Drawing.Point(6, 169);
            this.rdStop.Name = "rdStop";
            this.rdStop.Size = new System.Drawing.Size(54, 17);
            this.rdStop.TabIndex = 0;
            this.rdStop.TabStop = true;
            this.rdStop.Text = "STOP";
            this.rdStop.UseVisualStyleBackColor = true;
            this.rdStop.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdExclamation
            // 
            this.rdExclamation.AutoSize = true;
            this.rdExclamation.Location = new System.Drawing.Point(6, 77);
            this.rdExclamation.Name = "rdExclamation";
            this.rdExclamation.Size = new System.Drawing.Size(101, 17);
            this.rdExclamation.TabIndex = 0;
            this.rdExclamation.TabStop = true;
            this.rdExclamation.Text = "EXCLAMATION";
            this.rdExclamation.UseVisualStyleBackColor = true;
            this.rdExclamation.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdInform
            // 
            this.rdInform.AutoSize = true;
            this.rdInform.Location = new System.Drawing.Point(6, 123);
            this.rdInform.Name = "rdInform";
            this.rdInform.Size = new System.Drawing.Size(100, 17);
            this.rdInform.TabIndex = 0;
            this.rdInform.TabStop = true;
            this.rdInform.Text = "INFORMATION";
            this.rdInform.UseVisualStyleBackColor = true;
            this.rdInform.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // rdAsterisk
            // 
            this.rdAsterisk.AutoSize = true;
            this.rdAsterisk.Location = new System.Drawing.Point(6, 31);
            this.rdAsterisk.Name = "rdAsterisk";
            this.rdAsterisk.Size = new System.Drawing.Size(78, 17);
            this.rdAsterisk.TabIndex = 0;
            this.rdAsterisk.TabStop = true;
            this.rdAsterisk.Text = "ASTERISK";
            this.rdAsterisk.UseVisualStyleBackColor = true;
            this.rdAsterisk.CheckedChanged += new System.EventHandler(this.iconTypeChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.displayButton);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(18, 249);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Your Message";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(160, 288);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(162, 20);
            this.txtTitel.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(160, 265);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(162, 20);
            this.txtMessage.TabIndex = 5;
            // 
            // ErrorBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 320);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpIcon);
            this.Controls.Add(this.grpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ErrorBoxes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorBoxes";
            this.grpButton.ResumeLayout(false);
            this.grpButton.PerformLayout();
            this.grpIcon.ResumeLayout(false);
            this.grpIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.RadioButton rdYesNoCancel;
        private System.Windows.Forms.RadioButton rdRetryCancel;
        private System.Windows.Forms.RadioButton rdOkCancel;
        private System.Windows.Forms.RadioButton rdAborteryIgnore;
        private System.Windows.Forms.RadioButton rdYesNo;
        private System.Windows.Forms.RadioButton rdOk;
        private System.Windows.Forms.GroupBox grpIcon;
        private System.Windows.Forms.RadioButton rdHand;
        private System.Windows.Forms.RadioButton rdQuestion;
        private System.Windows.Forms.RadioButton rdError;
        private System.Windows.Forms.RadioButton rdWarning;
        private System.Windows.Forms.RadioButton rdStop;
        private System.Windows.Forms.RadioButton rdExclamation;
        private System.Windows.Forms.RadioButton rdInform;
        private System.Windows.Forms.RadioButton rdAsterisk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtMessage;
    }
}