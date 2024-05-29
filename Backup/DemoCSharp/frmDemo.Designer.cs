namespace Demo
{
    partial class frmDemo
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
            this.btnProgDemo1 = new System.Windows.Forms.Button();
            this.btnProgDemo2 = new System.Windows.Forms.Button();
            this.btnScrollDemo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStopScroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgDemo1
            // 
            this.btnProgDemo1.Location = new System.Drawing.Point(12, 12);
            this.btnProgDemo1.Name = "btnProgDemo1";
            this.btnProgDemo1.Size = new System.Drawing.Size(139, 23);
            this.btnProgDemo1.TabIndex = 0;
            this.btnProgDemo1.Text = "Progress Bar Demo 1";
            this.btnProgDemo1.UseVisualStyleBackColor = true;
            this.btnProgDemo1.Click += new System.EventHandler(this.btnProgDemo1_Click);
            // 
            // btnProgDemo2
            // 
            this.btnProgDemo2.Location = new System.Drawing.Point(13, 42);
            this.btnProgDemo2.Name = "btnProgDemo2";
            this.btnProgDemo2.Size = new System.Drawing.Size(138, 23);
            this.btnProgDemo2.TabIndex = 1;
            this.btnProgDemo2.Text = "Progress Bar Demo 2";
            this.btnProgDemo2.UseVisualStyleBackColor = true;
            this.btnProgDemo2.Click += new System.EventHandler(this.btnProgDemo2_Click);
            // 
            // btnScrollDemo
            // 
            this.btnScrollDemo.Location = new System.Drawing.Point(13, 72);
            this.btnScrollDemo.Name = "btnScrollDemo";
            this.btnScrollDemo.Size = new System.Drawing.Size(138, 23);
            this.btnScrollDemo.TabIndex = 2;
            this.btnScrollDemo.Text = "Scrolling Text Demo";
            this.btnScrollDemo.UseVisualStyleBackColor = true;
            this.btnScrollDemo.Click += new System.EventHandler(this.btnScrollDemo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStopScroll
            // 
            this.btnStopScroll.Enabled = false;
            this.btnStopScroll.Location = new System.Drawing.Point(52, 102);
            this.btnStopScroll.Name = "btnStopScroll";
            this.btnStopScroll.Size = new System.Drawing.Size(95, 23);
            this.btnStopScroll.TabIndex = 4;
            this.btnStopScroll.Text = "Stop Scrolling";
            this.btnStopScroll.UseVisualStyleBackColor = true;
            this.btnStopScroll.Click += new System.EventHandler(this.btnStopScroll_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 172);
            this.Controls.Add(this.btnStopScroll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnScrollDemo);
            this.Controls.Add(this.btnProgDemo2);
            this.Controls.Add(this.btnProgDemo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDemo";
            this.Text = "Demo Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgDemo1;
        private System.Windows.Forms.Button btnProgDemo2;
        private System.Windows.Forms.Button btnScrollDemo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStopScroll;
    }
}