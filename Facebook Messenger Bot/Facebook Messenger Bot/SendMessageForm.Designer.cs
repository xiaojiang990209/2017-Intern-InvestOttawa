using System.Drawing;

namespace WindowsFormsApplication2
{
    partial class FacebookMessengerBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookMessengerBot));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.minTimeDelay = new System.Windows.Forms.TextBox();
            this.maxTimeDelay = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.TextBox();
            this.Summary = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.fileOpen = new System.Windows.Forms.Button();
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(306, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(545, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Delay ( seconds )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time Option ( HH:MM )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "End";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.Font = new System.Drawing.Font("Consolas", 10F);
            this.userName.Location = new System.Drawing.Point(394, 19);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(131, 23);
            this.userName.TabIndex = 9;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Consolas", 10F);
            this.password.Location = new System.Drawing.Point(632, 19);
            this.password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(92, 23);
            this.password.TabIndex = 10;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // minTimeDelay
            // 
            this.minTimeDelay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTimeDelay.Location = new System.Drawing.Point(55, 50);
            this.minTimeDelay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.minTimeDelay.Name = "minTimeDelay";
            this.minTimeDelay.Size = new System.Drawing.Size(119, 23);
            this.minTimeDelay.TabIndex = 11;
            this.minTimeDelay.TextChanged += new System.EventHandler(this.minTimeDelay_TextChanged);
            // 
            // maxTimeDelay
            // 
            this.maxTimeDelay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTimeDelay.Location = new System.Drawing.Point(55, 82);
            this.maxTimeDelay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maxTimeDelay.Name = "maxTimeDelay";
            this.maxTimeDelay.Size = new System.Drawing.Size(119, 23);
            this.maxTimeDelay.TabIndex = 12;
            this.maxTimeDelay.TextChanged += new System.EventHandler(this.maxTimeDelay_TextChanged);
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Location = new System.Drawing.Point(55, 148);
            this.startTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(119, 23);
            this.startTime.TabIndex = 13;
            this.startTime.TextChanged += new System.EventHandler(this.startTime_TextChanged);
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Location = new System.Drawing.Point(55, 180);
            this.endTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(119, 23);
            this.endTime.TabIndex = 14;
            this.endTime.TextChanged += new System.EventHandler(this.endTime_TextChanged);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(233, 107);
            this.text.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(486, 98);
            this.text.TabIndex = 15;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Facebook Text";
            // 
            // summaryBox
            // 
            this.summaryBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.summaryBox.Location = new System.Drawing.Point(233, 256);
            this.summaryBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.summaryBox.Multiline = true;
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryBox.Size = new System.Drawing.Size(486, 103);
            this.summaryBox.TabIndex = 17;
            this.summaryBox.UseWaitCursor = true;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.Location = new System.Drawing.Point(427, 219);
            this.Summary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(94, 24);
            this.Summary.TabIndex = 18;
            this.Summary.Text = "Summary";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(55, 289);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(74, 24);
            this.sendButton.TabIndex = 19;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.AllowDrop = true;
            this.fileOpen.BackColor = System.Drawing.Color.White;
            this.fileOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileOpen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpen.Location = new System.Drawing.Point(55, 226);
            this.fileOpen.Margin = new System.Windows.Forms.Padding(0);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(74, 25);
            this.fileOpen.TabIndex = 20;
            this.fileOpen.Text = "Open";
            this.fileOpen.UseVisualStyleBackColor = false;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileLoadedLabel
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLoadedLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLoadedLabel.ForeColor = System.Drawing.Color.Black;
            this.fileLoadedLabel.Location = new System.Drawing.Point(43, 260);
            this.fileLoadedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileLoadedLabel.Name = "fileLoadedLabel";
            this.fileLoadedLabel.Size = new System.Drawing.Size(105, 15);
            this.fileLoadedLabel.TabIndex = 21;
            this.fileLoadedLabel.Text = "No loaded file";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 57);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.sendButton);
            this.panel2.Controls.Add(this.fileLoadedLabel);
            this.panel2.Controls.Add(this.fileOpen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.minTimeDelay);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.maxTimeDelay);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.endTime);
            this.panel2.Controls.Add(this.startTime);
            this.panel2.Location = new System.Drawing.Point(-4, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 327);
            this.panel2.TabIndex = 24;
            // 
            // FacebookMessengerBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(734, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FacebookMessengerBot";
            this.Text = "Facebook Page Messenger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox minTimeDelay;
        private System.Windows.Forms.TextBox maxTimeDelay;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox summaryBox;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.Label fileLoadedLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

