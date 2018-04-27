namespace SMSSender
{
    partial class SendSmsForm
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
            this.messageTextTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browserFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCharactorsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextTextBox
            // 
            this.messageTextTextBox.Location = new System.Drawing.Point(251, 24);
            this.messageTextTextBox.Name = "messageTextTextBox";
            this.messageTextTextBox.Size = new System.Drawing.Size(820, 202);
            this.messageTextTextBox.TabIndex = 0;
            this.messageTextTextBox.Text = "";
            this.messageTextTextBox.TextChanged += new System.EventHandler(this.messageTextTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Text";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(494, 365);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(187, 63);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(251, 293);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(666, 31);
            this.filePathTextBox.TabIndex = 3;
            // 
            // browserFileButton
            // 
            this.browserFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserFileButton.Location = new System.Drawing.Point(953, 293);
            this.browserFileButton.Name = "browserFileButton";
            this.browserFileButton.Size = new System.Drawing.Size(118, 39);
            this.browserFileButton.TabIndex = 4;
            this.browserFileButton.Text = "Browse";
            this.browserFileButton.UseVisualStyleBackColor = true;
            this.browserFileButton.Click += new System.EventHandler(this.browserFileButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 89);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the Contact List (Excel File)";
            // 
            // totalCharactorsLabel
            // 
            this.totalCharactorsLabel.AutoSize = true;
            this.totalCharactorsLabel.Location = new System.Drawing.Point(883, 241);
            this.totalCharactorsLabel.Name = "totalCharactorsLabel";
            this.totalCharactorsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalCharactorsLabel.Size = new System.Drawing.Size(193, 25);
            this.totalCharactorsLabel.TabIndex = 5;
            this.totalCharactorsLabel.Text = "Character Count: 0";
            this.totalCharactorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1038, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do not click \'Send\' multiple times. Just click and wait. Application will give yo" +
    "u message once completed.";
            // 
            // SendSmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalCharactorsLabel);
            this.Controls.Add(this.browserFileButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SendSmsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageTextTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browserFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCharactorsLabel;
        private System.Windows.Forms.Label label3;
    }
}

