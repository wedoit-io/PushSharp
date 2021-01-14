
namespace TestApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.debugComboBox = new System.Windows.Forms.ComboBox();
            this.pushTypeComboBox = new System.Windows.Forms.ComboBox();
            this.deviceTokenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBoxt = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.certComboBox = new System.Windows.Forms.ComboBox();
            this.bundleIdComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Add = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resultAndroidTextBox = new System.Windows.Forms.TextBox();
            this.androidProgressBar = new System.Windows.Forms.ProgressBar();
            this.addAndroidButton = new System.Windows.Forms.Button();
            this.stopAndroidButton = new System.Windows.Forms.Button();
            this.startAndroidButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.androidMessageTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.regIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.senderAuthTokenTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Android";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "ios old";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // debugComboBox
            // 
            this.debugComboBox.FormattingEnabled = true;
            this.debugComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.debugComboBox.Location = new System.Drawing.Point(150, 89);
            this.debugComboBox.Name = "debugComboBox";
            this.debugComboBox.Size = new System.Drawing.Size(121, 21);
            this.debugComboBox.TabIndex = 3;
            this.debugComboBox.Text = "true";
            // 
            // pushTypeComboBox
            // 
            this.pushTypeComboBox.FormattingEnabled = true;
            this.pushTypeComboBox.Items.AddRange(new object[] {
            "alert",
            "voip"});
            this.pushTypeComboBox.Location = new System.Drawing.Point(8, 89);
            this.pushTypeComboBox.Name = "pushTypeComboBox";
            this.pushTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.pushTypeComboBox.TabIndex = 4;
            this.pushTypeComboBox.Text = "alert";
            // 
            // deviceTokenTextBox
            // 
            this.deviceTokenTextBox.Location = new System.Drawing.Point(8, 145);
            this.deviceTokenTextBox.Name = "deviceTokenTextBox";
            this.deviceTokenTextBox.Size = new System.Drawing.Size(575, 20);
            this.deviceTokenTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Debug ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Device Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // resultTextBoxt
            // 
            this.resultTextBoxt.Location = new System.Drawing.Point(11, 283);
            this.resultTextBoxt.Multiline = true;
            this.resultTextBoxt.Name = "resultTextBoxt";
            this.resultTextBoxt.Size = new System.Drawing.Size(572, 134);
            this.resultTextBoxt.TabIndex = 9;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(8, 195);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(277, 56);
            this.messageTextBox.TabIndex = 10;
            this.messageTextBox.Text = "Test Http2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message";
            // 
            // certComboBox
            // 
            this.certComboBox.FormattingEnabled = true;
            this.certComboBox.Location = new System.Drawing.Point(8, 32);
            this.certComboBox.Name = "certComboBox";
            this.certComboBox.Size = new System.Drawing.Size(575, 21);
            this.certComboBox.TabIndex = 12;
            // 
            // bundleIdComboBox
            // 
            this.bundleIdComboBox.FormattingEnabled = true;
            this.bundleIdComboBox.Items.AddRange(new object[] {
            "it.nethesis.nethcti3",
            "APX.Attendance"});
            this.bundleIdComboBox.Location = new System.Drawing.Point(304, 86);
            this.bundleIdComboBox.Name = "bundleIdComboBox";
            this.bundleIdComboBox.Size = new System.Drawing.Size(279, 21);
            this.bundleIdComboBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bundle ID ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 471);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.stopButton);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.resultTextBoxt);
            this.tabPage1.Controls.Add(this.bundleIdComboBox);
            this.tabPage1.Controls.Add(this.debugComboBox);
            this.tabPage1.Controls.Add(this.certComboBox);
            this.tabPage1.Controls.Add(this.pushTypeComboBox);
            this.tabPage1.Controls.Add(this.deviceTokenTextBox);
            this.tabPage1.Controls.Add(this.messageTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "iOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(411, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(330, 228);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 18;
            this.Add.Text = "Add queue";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(517, 195);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(330, 193);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Certificato";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultAndroidTextBox);
            this.tabPage2.Controls.Add(this.androidProgressBar);
            this.tabPage2.Controls.Add(this.addAndroidButton);
            this.tabPage2.Controls.Add(this.stopAndroidButton);
            this.tabPage2.Controls.Add(this.startAndroidButton);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.androidMessageTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.regIdTextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.senderAuthTokenTextBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Android";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultAndroidTextBox
            // 
            this.resultAndroidTextBox.Location = new System.Drawing.Point(11, 290);
            this.resultAndroidTextBox.Multiline = true;
            this.resultAndroidTextBox.Name = "resultAndroidTextBox";
            this.resultAndroidTextBox.Size = new System.Drawing.Size(572, 134);
            this.resultAndroidTextBox.TabIndex = 24;
            // 
            // androidProgressBar
            // 
            this.androidProgressBar.Location = new System.Drawing.Point(397, 182);
            this.androidProgressBar.Name = "androidProgressBar";
            this.androidProgressBar.Size = new System.Drawing.Size(100, 23);
            this.androidProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.androidProgressBar.TabIndex = 23;
            // 
            // addAndroidButton
            // 
            this.addAndroidButton.Location = new System.Drawing.Point(316, 217);
            this.addAndroidButton.Name = "addAndroidButton";
            this.addAndroidButton.Size = new System.Drawing.Size(75, 23);
            this.addAndroidButton.TabIndex = 22;
            this.addAndroidButton.Text = "Add queue";
            this.addAndroidButton.UseVisualStyleBackColor = true;
            this.addAndroidButton.Click += new System.EventHandler(this.addAndroidButton_Click);
            // 
            // stopAndroidButton
            // 
            this.stopAndroidButton.Location = new System.Drawing.Point(503, 184);
            this.stopAndroidButton.Name = "stopAndroidButton";
            this.stopAndroidButton.Size = new System.Drawing.Size(75, 23);
            this.stopAndroidButton.TabIndex = 21;
            this.stopAndroidButton.Text = "Stop";
            this.stopAndroidButton.UseVisualStyleBackColor = true;
            this.stopAndroidButton.Click += new System.EventHandler(this.stopAndroidButton_Click);
            // 
            // startAndroidButton
            // 
            this.startAndroidButton.Location = new System.Drawing.Point(316, 182);
            this.startAndroidButton.Name = "startAndroidButton";
            this.startAndroidButton.Size = new System.Drawing.Size(75, 23);
            this.startAndroidButton.TabIndex = 20;
            this.startAndroidButton.Text = "Start";
            this.startAndroidButton.UseVisualStyleBackColor = true;
            this.startAndroidButton.Click += new System.EventHandler(this.startAndroidButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Message";
            // 
            // androidMessageTextBox
            // 
            this.androidMessageTextBox.Location = new System.Drawing.Point(11, 182);
            this.androidMessageTextBox.Multiline = true;
            this.androidMessageTextBox.Name = "androidMessageTextBox";
            this.androidMessageTextBox.Size = new System.Drawing.Size(277, 56);
            this.androidMessageTextBox.TabIndex = 12;
            this.androidMessageTextBox.Text = "Test";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Reg Id";
            // 
            // regIdTextBox
            // 
            this.regIdTextBox.Location = new System.Drawing.Point(11, 103);
            this.regIdTextBox.Multiline = true;
            this.regIdTextBox.Name = "regIdTextBox";
            this.regIdTextBox.Size = new System.Drawing.Size(563, 41);
            this.regIdTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sender auth token";
            // 
            // senderAuthTokenTextBox
            // 
            this.senderAuthTokenTextBox.Location = new System.Drawing.Point(9, 33);
            this.senderAuthTokenTextBox.Multiline = true;
            this.senderAuthTokenTextBox.Name = "senderAuthTokenTextBox";
            this.senderAuthTokenTextBox.Size = new System.Drawing.Size(565, 38);
            this.senderAuthTokenTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Push Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox debugComboBox;
        private System.Windows.Forms.ComboBox pushTypeComboBox;
        private System.Windows.Forms.TextBox deviceTokenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBoxt;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox certComboBox;
        private System.Windows.Forms.ComboBox bundleIdComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox senderAuthTokenTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox androidMessageTextBox;
        private System.Windows.Forms.ProgressBar androidProgressBar;
        private System.Windows.Forms.Button addAndroidButton;
        private System.Windows.Forms.Button stopAndroidButton;
        private System.Windows.Forms.Button startAndroidButton;
        private System.Windows.Forms.TextBox resultAndroidTextBox;
    }
}

