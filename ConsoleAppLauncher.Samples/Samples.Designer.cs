namespace SlavaGu.ConsoleAppLauncher.Samples
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
            buttonGetIpAddress = new System.Windows.Forms.Button();
            labelIpAddress = new System.Windows.Forms.Label();
            buttonPing = new System.Windows.Forms.Button();
            labelPing = new System.Windows.Forms.Label();
            buttonVer = new System.Windows.Forms.Button();
            labelVer = new System.Windows.Forms.Label();
            buttonSkype = new System.Windows.Forms.Button();
            labelSkype = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            labelRClone = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // buttonGetIpAddress
            // 
            buttonGetIpAddress.Location = new System.Drawing.Point(14, 50);
            buttonGetIpAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGetIpAddress.Name = "buttonGetIpAddress";
            buttonGetIpAddress.Size = new System.Drawing.Size(152, 27);
            buttonGetIpAddress.TabIndex = 2;
            buttonGetIpAddress.Text = "Get local IP Address";
            buttonGetIpAddress.UseVisualStyleBackColor = true;
            buttonGetIpAddress.Click += buttonGetIpAddress_Click;
            // 
            // labelIpAddress
            // 
            labelIpAddress.AutoSize = true;
            labelIpAddress.Location = new System.Drawing.Point(173, 55);
            labelIpAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIpAddress.Name = "labelIpAddress";
            labelIpAddress.Size = new System.Drawing.Size(77, 15);
            labelIpAddress.TabIndex = 3;
            labelIpAddress.Text = "<ip address>";
            // 
            // buttonPing
            // 
            buttonPing.Location = new System.Drawing.Point(14, 83);
            buttonPing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new System.Drawing.Size(152, 27);
            buttonPing.TabIndex = 4;
            buttonPing.Text = "Ping google.com";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // labelPing
            // 
            labelPing.AutoSize = true;
            labelPing.Location = new System.Drawing.Point(173, 89);
            labelPing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPing.Name = "labelPing";
            labelPing.Size = new System.Drawing.Size(101, 15);
            labelPing.TabIndex = 5;
            labelPing.Text = "<roundtrip time>";
            // 
            // buttonVer
            // 
            buttonVer.Location = new System.Drawing.Point(14, 16);
            buttonVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new System.Drawing.Size(152, 27);
            buttonVer.TabIndex = 0;
            buttonVer.Text = "Get Windows Version";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // labelVer
            // 
            labelVer.AutoSize = true;
            labelVer.Location = new System.Drawing.Point(173, 22);
            labelVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVer.Name = "labelVer";
            labelVer.Size = new System.Drawing.Size(112, 15);
            labelVer.TabIndex = 1;
            labelVer.Text = "<windows version>";
            // 
            // buttonSkype
            // 
            buttonSkype.Location = new System.Drawing.Point(15, 118);
            buttonSkype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSkype.Name = "buttonSkype";
            buttonSkype.Size = new System.Drawing.Size(150, 27);
            buttonSkype.TabIndex = 6;
            buttonSkype.Text = "Get Skype Firewall rule";
            buttonSkype.UseVisualStyleBackColor = true;
            buttonSkype.Click += buttonSkype_Click;
            // 
            // labelSkype
            // 
            labelSkype.AutoSize = true;
            labelSkype.Location = new System.Drawing.Point(173, 123);
            labelSkype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSkype.Name = "labelSkype";
            labelSkype.Size = new System.Drawing.Size(119, 15);
            labelSkype.TabIndex = 7;
            labelSkype.Text = "<skype firewall rule>";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(16, 151);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 27);
            button1.TabIndex = 8;
            button1.Text = "Get RClone";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelRClone
            // 
            labelRClone.AutoSize = true;
            labelRClone.Location = new System.Drawing.Point(174, 157);
            labelRClone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRClone.Name = "labelRClone";
            labelRClone.Size = new System.Drawing.Size(62, 15);
            labelRClone.TabIndex = 9;
            labelRClone.Text = "<rClone >";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(248, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(363, 23);
            textBox1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(455, 348);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(536, 348);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(248, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(363, 23);
            textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(623, 383);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(labelRClone);
            Controls.Add(button1);
            Controls.Add(labelSkype);
            Controls.Add(buttonSkype);
            Controls.Add(labelVer);
            Controls.Add(buttonVer);
            Controls.Add(labelPing);
            Controls.Add(buttonPing);
            Controls.Add(labelIpAddress);
            Controls.Add(buttonGetIpAddress);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ConsoleAppLauncher Samples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonGetIpAddress;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Button buttonSkype;
        private System.Windows.Forms.Label labelSkype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRClone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

