namespace Demo
{
    partial class frmMain
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetupLiveDisplay = new System.Windows.Forms.Button();
            this.btnControlLeds = new System.Windows.Forms.Button();
            this.btnControlGPIO = new System.Windows.Forms.Button();
            this.btnShowConfigKeys = new System.Windows.Forms.Button();
            this.btnTemperatures = new System.Windows.Forms.Button();
            this.btnFans = new System.Windows.Forms.Button();
            this.btnCharacterSet = new System.Windows.Forms.Button();
            this.btnPacketDebugger = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBacklightPercent = new System.Windows.Forms.Label();
            this.lblContrastPercent = new System.Windows.Forms.Label();
            this.hsbBacklight = new System.Windows.Forms.HScrollBar();
            this.hsbContrast = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLine4Send = new System.Windows.Forms.Button();
            this.txtLine4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLine3Send = new System.Windows.Forms.Button();
            this.txtLine3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLine2Send = new System.Windows.Forms.Button();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLine1Send = new System.Windows.Forms.Button();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb115 = new System.Windows.Forms.RadioButton();
            this.rb19 = new System.Windows.Forms.RadioButton();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDemo);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnSetupLiveDisplay);
            this.groupBox5.Controls.Add(this.btnControlLeds);
            this.groupBox5.Controls.Add(this.btnControlGPIO);
            this.groupBox5.Controls.Add(this.btnShowConfigKeys);
            this.groupBox5.Controls.Add(this.btnTemperatures);
            this.groupBox5.Controls.Add(this.btnFans);
            this.groupBox5.Controls.Add(this.btnCharacterSet);
            this.groupBox5.Controls.Add(this.btnPacketDebugger);
            this.groupBox5.Location = new System.Drawing.Point(464, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 318);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Commands";
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(7, 255);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(144, 23);
            this.btnDemo.TabIndex = 9;
            this.btnDemo.Text = "Demos";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetupLiveDisplay
            // 
            this.btnSetupLiveDisplay.Enabled = false;
            this.btnSetupLiveDisplay.Location = new System.Drawing.Point(6, 224);
            this.btnSetupLiveDisplay.Name = "btnSetupLiveDisplay";
            this.btnSetupLiveDisplay.Size = new System.Drawing.Size(145, 23);
            this.btnSetupLiveDisplay.TabIndex = 7;
            this.btnSetupLiveDisplay.Text = "Setup Live Display";
            this.btnSetupLiveDisplay.UseVisualStyleBackColor = true;
            // 
            // btnControlLeds
            // 
            this.btnControlLeds.Enabled = false;
            this.btnControlLeds.Location = new System.Drawing.Point(6, 194);
            this.btnControlLeds.Name = "btnControlLeds";
            this.btnControlLeds.Size = new System.Drawing.Size(145, 23);
            this.btnControlLeds.TabIndex = 6;
            this.btnControlLeds.Text = "Control LEDs";
            this.btnControlLeds.UseVisualStyleBackColor = true;
            // 
            // btnControlGPIO
            // 
            this.btnControlGPIO.Enabled = false;
            this.btnControlGPIO.Location = new System.Drawing.Point(7, 165);
            this.btnControlGPIO.Name = "btnControlGPIO";
            this.btnControlGPIO.Size = new System.Drawing.Size(144, 23);
            this.btnControlGPIO.TabIndex = 5;
            this.btnControlGPIO.Text = "Control GPIO";
            this.btnControlGPIO.UseVisualStyleBackColor = true;
            // 
            // btnShowConfigKeys
            // 
            this.btnShowConfigKeys.Enabled = false;
            this.btnShowConfigKeys.Location = new System.Drawing.Point(7, 135);
            this.btnShowConfigKeys.Name = "btnShowConfigKeys";
            this.btnShowConfigKeys.Size = new System.Drawing.Size(144, 23);
            this.btnShowConfigKeys.TabIndex = 4;
            this.btnShowConfigKeys.Text = "Show / Configure Keys";
            this.btnShowConfigKeys.UseVisualStyleBackColor = true;
            // 
            // btnTemperatures
            // 
            this.btnTemperatures.Enabled = false;
            this.btnTemperatures.Location = new System.Drawing.Point(7, 105);
            this.btnTemperatures.Name = "btnTemperatures";
            this.btnTemperatures.Size = new System.Drawing.Size(144, 23);
            this.btnTemperatures.TabIndex = 3;
            this.btnTemperatures.Text = "Show Temperatures";
            this.btnTemperatures.UseVisualStyleBackColor = true;
            // 
            // btnFans
            // 
            this.btnFans.Location = new System.Drawing.Point(6, 76);
            this.btnFans.Name = "btnFans";
            this.btnFans.Size = new System.Drawing.Size(145, 23);
            this.btnFans.TabIndex = 2;
            this.btnFans.Text = "Show Fans";
            this.btnFans.UseVisualStyleBackColor = true;
            this.btnFans.Click += new System.EventHandler(this.btnFans_Click);
            // 
            // btnCharacterSet
            // 
            this.btnCharacterSet.Enabled = false;
            this.btnCharacterSet.Location = new System.Drawing.Point(7, 47);
            this.btnCharacterSet.Name = "btnCharacterSet";
            this.btnCharacterSet.Size = new System.Drawing.Size(144, 23);
            this.btnCharacterSet.TabIndex = 1;
            this.btnCharacterSet.Text = "Character Set";
            this.btnCharacterSet.UseVisualStyleBackColor = true;
            // 
            // btnPacketDebugger
            // 
            this.btnPacketDebugger.Location = new System.Drawing.Point(7, 17);
            this.btnPacketDebugger.Name = "btnPacketDebugger";
            this.btnPacketDebugger.Size = new System.Drawing.Size(144, 23);
            this.btnPacketDebugger.TabIndex = 0;
            this.btnPacketDebugger.Text = "Packet Debugger";
            this.btnPacketDebugger.UseVisualStyleBackColor = true;
            this.btnPacketDebugger.Click += new System.EventHandler(this.btnPacketDebugger_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBacklightPercent);
            this.groupBox4.Controls.Add(this.lblContrastPercent);
            this.groupBox4.Controls.Add(this.hsbBacklight);
            this.groupBox4.Controls.Add(this.hsbContrast);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(5, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 71);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contrast && Backlight Controls";
            // 
            // lblBacklightPercent
            // 
            this.lblBacklightPercent.Location = new System.Drawing.Point(358, 46);
            this.lblBacklightPercent.Name = "lblBacklightPercent";
            this.lblBacklightPercent.Size = new System.Drawing.Size(88, 17);
            this.lblBacklightPercent.TabIndex = 7;
            this.lblBacklightPercent.Text = "0%";
            this.lblBacklightPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrastPercent
            // 
            this.lblContrastPercent.Location = new System.Drawing.Point(358, 20);
            this.lblContrastPercent.Name = "lblContrastPercent";
            this.lblContrastPercent.Size = new System.Drawing.Size(88, 17);
            this.lblContrastPercent.TabIndex = 6;
            this.lblContrastPercent.Text = "0%";
            this.lblContrastPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbBacklight
            // 
            this.hsbBacklight.Location = new System.Drawing.Point(80, 46);
            this.hsbBacklight.Name = "hsbBacklight";
            this.hsbBacklight.Size = new System.Drawing.Size(271, 17);
            this.hsbBacklight.TabIndex = 5;
            this.hsbBacklight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbBacklight_Scroll);
            // 
            // hsbContrast
            // 
            this.hsbContrast.Location = new System.Drawing.Point(80, 20);
            this.hsbContrast.Maximum = 255;
            this.hsbContrast.Name = "hsbContrast";
            this.hsbContrast.Size = new System.Drawing.Size(271, 17);
            this.hsbContrast.TabIndex = 4;
            this.hsbContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbContrast_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Backlight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contrast";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLine4Send);
            this.groupBox3.Controls.Add(this.txtLine4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnLine3Send);
            this.groupBox3.Controls.Add(this.txtLine3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnLine2Send);
            this.groupBox3.Controls.Add(this.txtLine2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnLine1Send);
            this.groupBox3.Controls.Add(this.txtLine1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(5, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 127);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Settings";
            // 
            // btnLine4Send
            // 
            this.btnLine4Send.Enabled = false;
            this.btnLine4Send.Location = new System.Drawing.Point(358, 97);
            this.btnLine4Send.Name = "btnLine4Send";
            this.btnLine4Send.Size = new System.Drawing.Size(88, 20);
            this.btnLine4Send.TabIndex = 11;
            this.btnLine4Send.Text = "Send";
            this.btnLine4Send.UseVisualStyleBackColor = true;
            this.btnLine4Send.Click += new System.EventHandler(this.btnLine4Send_Click);
            // 
            // txtLine4
            // 
            this.txtLine4.Enabled = false;
            this.txtLine4.Location = new System.Drawing.Point(55, 97);
            this.txtLine4.Name = "txtLine4";
            this.txtLine4.Size = new System.Drawing.Size(296, 20);
            this.txtLine4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Line 4";
            // 
            // btnLine3Send
            // 
            this.btnLine3Send.Enabled = false;
            this.btnLine3Send.Location = new System.Drawing.Point(358, 71);
            this.btnLine3Send.Name = "btnLine3Send";
            this.btnLine3Send.Size = new System.Drawing.Size(88, 20);
            this.btnLine3Send.TabIndex = 8;
            this.btnLine3Send.Text = "Send";
            this.btnLine3Send.UseVisualStyleBackColor = true;
            this.btnLine3Send.Click += new System.EventHandler(this.btnLine3Send_Click);
            // 
            // txtLine3
            // 
            this.txtLine3.Enabled = false;
            this.txtLine3.Location = new System.Drawing.Point(55, 71);
            this.txtLine3.Name = "txtLine3";
            this.txtLine3.Size = new System.Drawing.Size(296, 20);
            this.txtLine3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line 3";
            // 
            // btnLine2Send
            // 
            this.btnLine2Send.Location = new System.Drawing.Point(358, 45);
            this.btnLine2Send.Name = "btnLine2Send";
            this.btnLine2Send.Size = new System.Drawing.Size(88, 20);
            this.btnLine2Send.TabIndex = 5;
            this.btnLine2Send.Text = "Send";
            this.btnLine2Send.UseVisualStyleBackColor = true;
            this.btnLine2Send.Click += new System.EventHandler(this.btnLine2Send_Click);
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(55, 45);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(296, 20);
            this.txtLine2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Line 2";
            // 
            // btnLine1Send
            // 
            this.btnLine1Send.Location = new System.Drawing.Point(358, 19);
            this.btnLine1Send.Name = "btnLine1Send";
            this.btnLine1Send.Size = new System.Drawing.Size(88, 20);
            this.btnLine1Send.TabIndex = 2;
            this.btnLine1Send.Text = "Send";
            this.btnLine1Send.UseVisualStyleBackColor = true;
            this.btnLine1Send.Click += new System.EventHandler(this.btnLine1Send_Click);
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(55, 19);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(296, 20);
            this.txtLine1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Line 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communications Port";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(194, 62);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(252, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(13, 20);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(433, 21);
            this.cmbPorts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb115);
            this.groupBox2.Controls.Add(this.rb19);
            this.groupBox2.Location = new System.Drawing.Point(13, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 38);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // rb115
            // 
            this.rb115.AutoSize = true;
            this.rb115.Location = new System.Drawing.Point(67, 15);
            this.rb115.Name = "rb115";
            this.rb115.Size = new System.Drawing.Size(61, 17);
            this.rb115.TabIndex = 1;
            this.rb115.Text = "115200";
            this.rb115.UseVisualStyleBackColor = true;
            // 
            // rb19
            // 
            this.rb19.AutoSize = true;
            this.rb19.Location = new System.Drawing.Point(6, 15);
            this.rb19.Name = "rb19";
            this.rb19.Size = new System.Drawing.Size(55, 17);
            this.rb19.TabIndex = 0;
            this.rb19.Text = "19200";
            this.rb19.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystalfontz 63X WinTest Clone";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetupLiveDisplay;
        private System.Windows.Forms.Button btnControlLeds;
        private System.Windows.Forms.Button btnControlGPIO;
        private System.Windows.Forms.Button btnShowConfigKeys;
        private System.Windows.Forms.Button btnTemperatures;
        private System.Windows.Forms.Button btnFans;
        private System.Windows.Forms.Button btnCharacterSet;
        private System.Windows.Forms.Button btnPacketDebugger;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBacklightPercent;
        private System.Windows.Forms.Label lblContrastPercent;
        private System.Windows.Forms.HScrollBar hsbBacklight;
        private System.Windows.Forms.HScrollBar hsbContrast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLine4Send;
        private System.Windows.Forms.TextBox txtLine4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLine3Send;
        private System.Windows.Forms.TextBox txtLine3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLine2Send;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLine1Send;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb115;
        private System.Windows.Forms.RadioButton rb19;
        private System.Windows.Forms.Button btnDemo;
    }
}

