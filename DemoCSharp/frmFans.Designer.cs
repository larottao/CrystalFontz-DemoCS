namespace Demo
{
    partial class frmFans
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
            this.chkFan1 = new System.Windows.Forms.CheckBox();
            this.lblRPMSFan1 = new System.Windows.Forms.Label();
            this.lblFan1Power = new System.Windows.Forms.Label();
            this.vsFan1 = new System.Windows.Forms.VScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFan2 = new System.Windows.Forms.CheckBox();
            this.lblRPMSFan2 = new System.Windows.Forms.Label();
            this.lblFan2Power = new System.Windows.Forms.Label();
            this.vsFan2 = new System.Windows.Forms.VScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFan3 = new System.Windows.Forms.CheckBox();
            this.lblRPMSFan3 = new System.Windows.Forms.Label();
            this.lblFan3Power = new System.Windows.Forms.Label();
            this.vsFan3 = new System.Windows.Forms.VScrollBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkFan4 = new System.Windows.Forms.CheckBox();
            this.lblRPMSFan4 = new System.Windows.Forms.Label();
            this.lblFan4Power = new System.Windows.Forms.Label();
            this.vsFan4 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFan1);
            this.groupBox1.Controls.Add(this.lblRPMSFan1);
            this.groupBox1.Controls.Add(this.lblFan1Power);
            this.groupBox1.Controls.Add(this.vsFan1);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fan 1";
            // 
            // chkFan1
            // 
            this.chkFan1.AutoSize = true;
            this.chkFan1.Location = new System.Drawing.Point(7, 157);
            this.chkFan1.Name = "chkFan1";
            this.chkFan1.Size = new System.Drawing.Size(59, 17);
            this.chkFan1.TabIndex = 6;
            this.chkFan1.Text = "Enable";
            this.chkFan1.UseVisualStyleBackColor = true;
            this.chkFan1.CheckedChanged += new System.EventHandler(this.chkFan1_CheckedChanged);
            // 
            // lblRPMSFan1
            // 
            this.lblRPMSFan1.Location = new System.Drawing.Point(6, 16);
            this.lblRPMSFan1.Name = "lblRPMSFan1";
            this.lblRPMSFan1.Size = new System.Drawing.Size(63, 13);
            this.lblRPMSFan1.TabIndex = 5;
            this.lblRPMSFan1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFan1Power
            // 
            this.lblFan1Power.AutoSize = true;
            this.lblFan1Power.Location = new System.Drawing.Point(23, 141);
            this.lblFan1Power.Name = "lblFan1Power";
            this.lblFan1Power.Size = new System.Drawing.Size(33, 13);
            this.lblFan1Power.TabIndex = 4;
            this.lblFan1Power.Text = "100%";
            // 
            // vsFan1
            // 
            this.vsFan1.Location = new System.Drawing.Point(30, 33);
            this.vsFan1.Name = "vsFan1";
            this.vsFan1.Size = new System.Drawing.Size(17, 103);
            this.vsFan1.TabIndex = 0;
            this.vsFan1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsFan1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFan2);
            this.groupBox2.Controls.Add(this.lblRPMSFan2);
            this.groupBox2.Controls.Add(this.lblFan2Power);
            this.groupBox2.Controls.Add(this.vsFan2);
            this.groupBox2.Location = new System.Drawing.Point(83, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fan 2";
            // 
            // chkFan2
            // 
            this.chkFan2.AutoSize = true;
            this.chkFan2.Location = new System.Drawing.Point(7, 157);
            this.chkFan2.Name = "chkFan2";
            this.chkFan2.Size = new System.Drawing.Size(59, 17);
            this.chkFan2.TabIndex = 6;
            this.chkFan2.Text = "Enable";
            this.chkFan2.UseVisualStyleBackColor = true;
            // 
            // lblRPMSFan2
            // 
            this.lblRPMSFan2.Location = new System.Drawing.Point(7, 16);
            this.lblRPMSFan2.Name = "lblRPMSFan2";
            this.lblRPMSFan2.Size = new System.Drawing.Size(59, 13);
            this.lblRPMSFan2.TabIndex = 5;
            this.lblRPMSFan2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFan2Power
            // 
            this.lblFan2Power.AutoSize = true;
            this.lblFan2Power.Location = new System.Drawing.Point(23, 141);
            this.lblFan2Power.Name = "lblFan2Power";
            this.lblFan2Power.Size = new System.Drawing.Size(33, 13);
            this.lblFan2Power.TabIndex = 4;
            this.lblFan2Power.Text = "100%";
            // 
            // vsFan2
            // 
            this.vsFan2.Location = new System.Drawing.Point(30, 33);
            this.vsFan2.Name = "vsFan2";
            this.vsFan2.Size = new System.Drawing.Size(17, 103);
            this.vsFan2.TabIndex = 0;
            this.vsFan2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsFan2_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFan3);
            this.groupBox3.Controls.Add(this.lblRPMSFan3);
            this.groupBox3.Controls.Add(this.lblFan3Power);
            this.groupBox3.Controls.Add(this.vsFan3);
            this.groupBox3.Location = new System.Drawing.Point(165, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(76, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fan 3";
            // 
            // chkFan3
            // 
            this.chkFan3.AutoSize = true;
            this.chkFan3.Location = new System.Drawing.Point(10, 157);
            this.chkFan3.Name = "chkFan3";
            this.chkFan3.Size = new System.Drawing.Size(59, 17);
            this.chkFan3.TabIndex = 6;
            this.chkFan3.Text = "Enable";
            this.chkFan3.UseVisualStyleBackColor = true;
            // 
            // lblRPMSFan3
            // 
            this.lblRPMSFan3.Location = new System.Drawing.Point(10, 16);
            this.lblRPMSFan3.Name = "lblRPMSFan3";
            this.lblRPMSFan3.Size = new System.Drawing.Size(64, 13);
            this.lblRPMSFan3.TabIndex = 5;
            this.lblRPMSFan3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFan3Power
            // 
            this.lblFan3Power.AutoSize = true;
            this.lblFan3Power.Location = new System.Drawing.Point(23, 141);
            this.lblFan3Power.Name = "lblFan3Power";
            this.lblFan3Power.Size = new System.Drawing.Size(33, 13);
            this.lblFan3Power.TabIndex = 4;
            this.lblFan3Power.Text = "100%";
            // 
            // vsFan3
            // 
            this.vsFan3.Location = new System.Drawing.Point(30, 33);
            this.vsFan3.Name = "vsFan3";
            this.vsFan3.Size = new System.Drawing.Size(17, 103);
            this.vsFan3.TabIndex = 0;
            this.vsFan3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsFan3_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkFan4);
            this.groupBox4.Controls.Add(this.lblRPMSFan4);
            this.groupBox4.Controls.Add(this.lblFan4Power);
            this.groupBox4.Controls.Add(this.vsFan4);
            this.groupBox4.Location = new System.Drawing.Point(259, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(76, 184);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fan 4";
            // 
            // chkFan4
            // 
            this.chkFan4.AutoSize = true;
            this.chkFan4.Location = new System.Drawing.Point(10, 157);
            this.chkFan4.Name = "chkFan4";
            this.chkFan4.Size = new System.Drawing.Size(59, 17);
            this.chkFan4.TabIndex = 6;
            this.chkFan4.Text = "Enable";
            this.chkFan4.UseVisualStyleBackColor = true;
            // 
            // lblRPMSFan4
            // 
            this.lblRPMSFan4.Location = new System.Drawing.Point(7, 16);
            this.lblRPMSFan4.Name = "lblRPMSFan4";
            this.lblRPMSFan4.Size = new System.Drawing.Size(67, 13);
            this.lblRPMSFan4.TabIndex = 5;
            this.lblRPMSFan4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFan4Power
            // 
            this.lblFan4Power.AutoSize = true;
            this.lblFan4Power.Location = new System.Drawing.Point(23, 141);
            this.lblFan4Power.Name = "lblFan4Power";
            this.lblFan4Power.Size = new System.Drawing.Size(33, 13);
            this.lblFan4Power.TabIndex = 4;
            this.lblFan4Power.Text = "100%";
            // 
            // vsFan4
            // 
            this.vsFan4.Location = new System.Drawing.Point(30, 33);
            this.vsFan4.Name = "vsFan4";
            this.vsFan4.Size = new System.Drawing.Size(17, 103);
            this.vsFan4.TabIndex = 0;
            this.vsFan4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsFan4_Scroll);
            // 
            // frmFans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 194);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFans";
            this.Text = "Fan Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vsFan1;
        private System.Windows.Forms.CheckBox chkFan1;
        private System.Windows.Forms.Label lblRPMSFan1;
        private System.Windows.Forms.Label lblFan1Power;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFan2;
        private System.Windows.Forms.Label lblRPMSFan2;
        private System.Windows.Forms.Label lblFan2Power;
        private System.Windows.Forms.VScrollBar vsFan2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFan3;
        private System.Windows.Forms.Label lblRPMSFan3;
        private System.Windows.Forms.Label lblFan3Power;
        private System.Windows.Forms.VScrollBar vsFan3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkFan4;
        private System.Windows.Forms.Label lblRPMSFan4;
        private System.Windows.Forms.Label lblFan4Power;
        private System.Windows.Forms.VScrollBar vsFan4;
    }
}