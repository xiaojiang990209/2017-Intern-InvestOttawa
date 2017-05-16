namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URL = new System.Windows.Forms.Label();
            this.urlAddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.BackColor = System.Drawing.Color.Transparent;
            this.URL.Font = new System.Drawing.Font("Inconsolata", 11F, System.Drawing.FontStyle.Bold);
            this.URL.Location = new System.Drawing.Point(-5, 76);
            this.URL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(399, 15);
            this.URL.TabIndex = 0;
            this.URL.Text = "1. Please enter the Home URL of the Meetup group:";
            // 
            // urlAddressBox
            // 
            this.urlAddressBox.Location = new System.Drawing.Point(16, 96);
            this.urlAddressBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.urlAddressBox.Name = "urlAddressBox";
            this.urlAddressBox.Size = new System.Drawing.Size(359, 21);
            this.urlAddressBox.TabIndex = 1;
            this.urlAddressBox.TextChanged += new System.EventHandler(this.urlAddressBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Handage AOE", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "M e e t u p    I D    S c r a p e r";
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateButton.Font = new System.Drawing.Font("Inconsolata", 10F);
            this.generateButton.Location = new System.Drawing.Point(67, 154);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(74, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Scrape";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inconsolata", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Click Scrape to scrape User IDs!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inconsolata", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(55, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "3. Click Open to view your file!";
            // 
            // openButton
            // 
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openButton.Font = new System.Drawing.Font("Inconsolata", 10F);
            this.openButton.Location = new System.Drawing.Point(146, 215);
            this.openButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(74, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Inconsolata", 10F);
            this.statusLabel.Location = new System.Drawing.Point(212, 159);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(126, 14);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Awaiting input...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 63);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.urlAddressBox);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meetup.com ID Scraper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox urlAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

