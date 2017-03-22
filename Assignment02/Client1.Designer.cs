namespace Assignment02
{
    partial class IMClient1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HNmee = new System.Windows.Forms.Label();
            this.textBoxHName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHPort = new System.Windows.Forms.TextBox();
            this.textBoxHostIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DesName = new System.Windows.Forms.Label();
            this.textBoxDesName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesPort = new System.Windows.Forms.TextBox();
            this.textBoxDesIP = new System.Windows.Forms.TextBox();
            this.listBoxClient1 = new System.Windows.Forms.ListBox();
            this.TextMessBoxC1 = new System.Windows.Forms.TextBox();
            this.buttConnect = new System.Windows.Forms.Button();
            this.buttCrypSend = new System.Windows.Forms.Button();
            this.buttSend = new System.Windows.Forms.Button();
            this.buttDisconnect = new System.Windows.Forms.Button();
            this.textBoxEMessage = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HNmee);
            this.groupBox2.Controls.Add(this.textBoxHName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxHPort);
            this.groupBox2.Controls.Add(this.textBoxHostIP);
            this.groupBox2.Location = new System.Drawing.Point(14, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(272, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // HNmee
            // 
            this.HNmee.AutoSize = true;
            this.HNmee.Location = new System.Drawing.Point(9, 32);
            this.HNmee.Name = "HNmee";
            this.HNmee.Size = new System.Drawing.Size(53, 20);
            this.HNmee.TabIndex = 5;
            this.HNmee.Text = "Name";
            // 
            // textBoxHName
            // 
            this.textBoxHName.Location = new System.Drawing.Point(79, 32);
            this.textBoxHName.Name = "textBoxHName";
            this.textBoxHName.Size = new System.Drawing.Size(164, 27);
            this.textBoxHName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // textBoxHPort
            // 
            this.textBoxHPort.Location = new System.Drawing.Point(79, 131);
            this.textBoxHPort.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxHPort.Name = "textBoxHPort";
            this.textBoxHPort.Size = new System.Drawing.Size(164, 27);
            this.textBoxHPort.TabIndex = 1;
            // 
            // textBoxHostIP
            // 
            this.textBoxHostIP.Location = new System.Drawing.Point(79, 77);
            this.textBoxHostIP.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxHostIP.Name = "textBoxHostIP";
            this.textBoxHostIP.Size = new System.Drawing.Size(164, 27);
            this.textBoxHostIP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DesName);
            this.groupBox1.Controls.Add(this.textBoxDesName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDesPort);
            this.groupBox1.Controls.Add(this.textBoxDesIP);
            this.groupBox1.Location = new System.Drawing.Point(296, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(264, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To";
            // 
            // DesName
            // 
            this.DesName.AutoSize = true;
            this.DesName.Location = new System.Drawing.Point(14, 32);
            this.DesName.Name = "DesName";
            this.DesName.Size = new System.Drawing.Size(53, 20);
            this.DesName.TabIndex = 5;
            this.DesName.Text = "Name";
            // 
            // textBoxDesName
            // 
            this.textBoxDesName.Location = new System.Drawing.Point(74, 32);
            this.textBoxDesName.Name = "textBoxDesName";
            this.textBoxDesName.Size = new System.Drawing.Size(164, 27);
            this.textBoxDesName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // textBoxDesPort
            // 
            this.textBoxDesPort.Location = new System.Drawing.Point(74, 124);
            this.textBoxDesPort.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDesPort.Name = "textBoxDesPort";
            this.textBoxDesPort.Size = new System.Drawing.Size(164, 27);
            this.textBoxDesPort.TabIndex = 1;
            // 
            // textBoxDesIP
            // 
            this.textBoxDesIP.Location = new System.Drawing.Point(74, 77);
            this.textBoxDesIP.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDesIP.Name = "textBoxDesIP";
            this.textBoxDesIP.Size = new System.Drawing.Size(164, 27);
            this.textBoxDesIP.TabIndex = 0;
            // 
            // listBoxClient1
            // 
            this.listBoxClient1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClient1.FormattingEnabled = true;
            this.listBoxClient1.ItemHeight = 20;
            this.listBoxClient1.Location = new System.Drawing.Point(4, 267);
            this.listBoxClient1.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxClient1.Name = "listBoxClient1";
            this.listBoxClient1.Size = new System.Drawing.Size(556, 244);
            this.listBoxClient1.TabIndex = 3;
            // 
            // TextMessBoxC1
            // 
            this.TextMessBoxC1.Location = new System.Drawing.Point(4, 530);
            this.TextMessBoxC1.Margin = new System.Windows.Forms.Padding(5);
            this.TextMessBoxC1.Multiline = true;
            this.TextMessBoxC1.Name = "TextMessBoxC1";
            this.TextMessBoxC1.Size = new System.Drawing.Size(556, 67);
            this.TextMessBoxC1.TabIndex = 4;
            // 
            // buttConnect
            // 
            this.buttConnect.Location = new System.Drawing.Point(621, 53);
            this.buttConnect.Margin = new System.Windows.Forms.Padding(5);
            this.buttConnect.Name = "buttConnect";
            this.buttConnect.Size = new System.Drawing.Size(103, 44);
            this.buttConnect.TabIndex = 5;
            this.buttConnect.Text = "Connect";
            this.buttConnect.UseVisualStyleBackColor = true;
            this.buttConnect.Click += new System.EventHandler(this.buttConnect_Click);
            // 
            // buttCrypSend
            // 
            this.buttCrypSend.Location = new System.Drawing.Point(596, 435);
            this.buttCrypSend.Margin = new System.Windows.Forms.Padding(5);
            this.buttCrypSend.Name = "buttCrypSend";
            this.buttCrypSend.Size = new System.Drawing.Size(128, 54);
            this.buttCrypSend.TabIndex = 6;
            this.buttCrypSend.Text = "Encrypt Send";
            this.buttCrypSend.UseVisualStyleBackColor = true;
            this.buttCrypSend.Click += new System.EventHandler(this.buttCrypSend_Click);
            // 
            // buttSend
            // 
            this.buttSend.Location = new System.Drawing.Point(596, 520);
            this.buttSend.Margin = new System.Windows.Forms.Padding(5);
            this.buttSend.Name = "buttSend";
            this.buttSend.Size = new System.Drawing.Size(128, 46);
            this.buttSend.TabIndex = 7;
            this.buttSend.Text = "Send";
            this.buttSend.UseVisualStyleBackColor = true;
            this.buttSend.Click += new System.EventHandler(this.buttSend_Click);
            // 
            // buttDisconnect
            // 
            this.buttDisconnect.Location = new System.Drawing.Point(612, 136);
            this.buttDisconnect.Name = "buttDisconnect";
            this.buttDisconnect.Size = new System.Drawing.Size(112, 45);
            this.buttDisconnect.TabIndex = 8;
            this.buttDisconnect.Text = "Disconnenct";
            this.buttDisconnect.UseVisualStyleBackColor = true;
            this.buttDisconnect.Click += new System.EventHandler(this.buttDisconnect_Click);
            // 
            // textBoxEMessage
            // 
            this.textBoxEMessage.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEMessage.Location = new System.Drawing.Point(4, 226);
            this.textBoxEMessage.Name = "textBoxEMessage";
            this.textBoxEMessage.Size = new System.Drawing.Size(556, 27);
            this.textBoxEMessage.TabIndex = 9;
            this.textBoxEMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IMClient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.textBoxEMessage);
            this.Controls.Add(this.buttDisconnect);
            this.Controls.Add(this.buttSend);
            this.Controls.Add(this.buttCrypSend);
            this.Controls.Add(this.buttConnect);
            this.Controls.Add(this.TextMessBoxC1);
            this.Controls.Add(this.listBoxClient1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IMClient1";
            this.Text = "Client1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHPort;
        private System.Windows.Forms.TextBox textBoxHostIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesPort;
        private System.Windows.Forms.TextBox textBoxDesIP;
        private System.Windows.Forms.ListBox listBoxClient1;
        private System.Windows.Forms.TextBox TextMessBoxC1;
        private System.Windows.Forms.Button buttConnect;
        private System.Windows.Forms.Button buttCrypSend;
        private System.Windows.Forms.Button buttSend;
        private System.Windows.Forms.Button buttDisconnect;
        private System.Windows.Forms.Label HNmee;
        private System.Windows.Forms.TextBox textBoxHName;
        private System.Windows.Forms.Label DesName;
        private System.Windows.Forms.TextBox textBoxDesName;
        private System.Windows.Forms.TextBox textBoxEMessage;
    }
}

