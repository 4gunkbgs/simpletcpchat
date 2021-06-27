namespace NewTCPChat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextLocalPort = new System.Windows.Forms.TextBox();
            this.TextLocalIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextRemotePort = new System.Windows.Forms.TextBox();
            this.TextRemoteIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ListMessage = new System.Windows.Forms.ListBox();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextLocalPort);
            this.groupBox1.Controls.Add(this.TextLocalIp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // TextLocalPort
            // 
            this.TextLocalPort.Location = new System.Drawing.Point(63, 62);
            this.TextLocalPort.Name = "TextLocalPort";
            this.TextLocalPort.Size = new System.Drawing.Size(100, 20);
            this.TextLocalPort.TabIndex = 5;
            // 
            // TextLocalIp
            // 
            this.TextLocalIp.Location = new System.Drawing.Point(63, 29);
            this.TextLocalIp.Name = "TextLocalIp";
            this.TextLocalIp.Size = new System.Drawing.Size(100, 20);
            this.TextLocalIp.TabIndex = 4;            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextRemotePort);
            this.groupBox2.Controls.Add(this.TextRemoteIp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // TextRemotePort
            // 
            this.TextRemotePort.Location = new System.Drawing.Point(63, 62);
            this.TextRemotePort.Name = "TextRemotePort";
            this.TextRemotePort.Size = new System.Drawing.Size(100, 20);
            this.TextRemotePort.TabIndex = 3;
            // 
            // TextRemoteIp
            // 
            this.TextRemoteIp.Location = new System.Drawing.Point(63, 29);
            this.TextRemoteIp.Name = "TextRemoteIp";
            this.TextRemoteIp.Size = new System.Drawing.Size(100, 20);
            this.TextRemoteIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(478, 44);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 31);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ListMessage
            // 
            this.ListMessage.FormattingEnabled = true;
            this.ListMessage.Location = new System.Drawing.Point(39, 118);
            this.ListMessage.Name = "ListMessage";
            this.ListMessage.Size = new System.Drawing.Size(524, 173);
            this.ListMessage.TabIndex = 3;
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(39, 308);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(420, 20);
            this.TextMessage.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(478, 306);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 349);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.ListMessage);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextLocalPort;
        private System.Windows.Forms.TextBox TextLocalIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextRemotePort;
        private System.Windows.Forms.TextBox TextRemoteIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox ListMessage;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

