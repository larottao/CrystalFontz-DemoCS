namespace Demo
{
    partial class frmPacketDebugger
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
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkPacket = new System.Windows.Forms.CheckBox();
            this.chkPacketIDHex = new System.Windows.Forms.CheckBox();
            this.dgvPackets = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnClose);
            this.grpSettings.Controls.Add(this.chkPacket);
            this.grpSettings.Controls.Add(this.chkPacketIDHex);
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSettings.Location = new System.Drawing.Point(0, 0);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(687, 42);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(600, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkPacket
            // 
            this.chkPacket.AutoSize = true;
            this.chkPacket.Checked = true;
            this.chkPacket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPacket.Location = new System.Drawing.Point(151, 20);
            this.chkPacket.Name = "chkPacket";
            this.chkPacket.Size = new System.Drawing.Size(122, 17);
            this.chkPacket.TabIndex = 1;
            this.chkPacket.Text = "Packet Data as Hex";
            this.chkPacket.UseVisualStyleBackColor = true;
            // 
            // chkPacketIDHex
            // 
            this.chkPacketIDHex.AutoSize = true;
            this.chkPacketIDHex.Checked = true;
            this.chkPacketIDHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPacketIDHex.Location = new System.Drawing.Point(7, 20);
            this.chkPacketIDHex.Name = "chkPacketIDHex";
            this.chkPacketIDHex.Size = new System.Drawing.Size(107, 17);
            this.chkPacketIDHex.TabIndex = 0;
            this.chkPacketIDHex.Text = "PacketID as Hex";
            this.chkPacketIDHex.UseVisualStyleBackColor = true;
            // 
            // dgvPackets
            // 
            this.dgvPackets.AllowUserToAddRows = false;
            this.dgvPackets.AllowUserToDeleteRows = false;
            this.dgvPackets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackets.Location = new System.Drawing.Point(0, 0);
            this.dgvPackets.Name = "dgvPackets";
            this.dgvPackets.Size = new System.Drawing.Size(687, 174);
            this.dgvPackets.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPackets);
            this.splitContainer1.Size = new System.Drawing.Size(687, 220);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmPacketDebugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 220);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPacketDebugger";
            this.Text = "Packet Viewer";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox chkPacketIDHex;
        private System.Windows.Forms.CheckBox chkPacket;
        private System.Windows.Forms.DataGridView dgvPackets;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}