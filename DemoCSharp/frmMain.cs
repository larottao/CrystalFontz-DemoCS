using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Crystalfontz.Displays;
using Crystalfontz.Modules;

namespace Demo
{
    public partial class frmMain : Form
    {
        CFA63XDisplay _genericDisplay;
        ComDevice[] _devices;

        string _strLine1 = "";
        string _strLine2 = "";

        string _strLine3 = "";
        string _strLine4 = "";

        public frmMain(DeviceID Device)
        {
            InitializeComponent();
            switch (Device)
            {
                case DeviceID.CFA631:
                    _genericDisplay = new CFA631();
                    this.Text = this.Text.Replace('X', '1');
                    break;
                case DeviceID.CFA633:
                    _genericDisplay = new CFA633();
                    this.Text = this.Text.Replace('X', '3');
                    break;
                case DeviceID.CFA635:
                    _genericDisplay = new CFA635();
                    this.Text = this.Text.Replace('X', '5');
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Here we are setting the port we are connected to
            _devices = SerialPorts.ComPorts;
            cmbPorts.DataSource = _devices;
            cmbPorts.DisplayMember = "Name";
            cmbPorts.ValueMember = "PortName";
            cmbPorts.SelectedValue = _genericDisplay.PortName;

            //Add event handlers
            _genericDisplay.HardwareFirmwareVersion += new CFA63XDisplay.HardwareFirmwareVersionHandler(_genericDisplay_HardwareFirmwareVersion);
            _genericDisplay.ReportingAndStatus += new CFA63XDisplay.ReportingAndStatusHandler(_genericDisplay_ReportingAndStatus);
            _genericDisplay.ReadData += new CFA63XDisplay.ReadDataHandler(_genericDisplay_ReadData);

            //Call to get the Hardware and Firmware Version
            _genericDisplay.GetHardwareFirmwareVersion();

            if (_genericDisplay.DeviceModel == DeviceID.CFA635)
            {
                txtLine3.Enabled = true;
                btnLine3Send.Enabled = true;
                txtLine4.Enabled = true;
                btnLine4Send.Enabled = true;
            }
            else
            {
                //This will read line 0 and line 1 of CFA631 && CFA633
                //Feel free to see the constant RamLocations
                //I do alot of firmware base stuff so hex doesn't scare me and I love it :)
                _genericDisplay.Read8BytesOfLCDMemory(0x80);
                _genericDisplay.Read8BytesOfLCDMemory(0x88);

                _genericDisplay.Read8BytesOfLCDMemory(0xC0);
                _genericDisplay.Read8BytesOfLCDMemory(0xC8);
            }

            //Make sure we are connected and do gui logic
            if (_genericDisplay.IsOpen)
            {
                cmbPorts.Enabled = false;
            }

            //gui logic to display baudrate
            if (_genericDisplay.BaudRate == 19200)
            {
                rb19.Checked = true;
            }
            else
            {
                rb115.Checked = true;
            }

            //Request the Contrast and Brightness
            _genericDisplay.ReadReportingStatus();
        }

        void _genericDisplay_ReadData(object sender, CFAReadDataEventArgs e)
        {
            //Checking for the address Ranges we want
            if (e.AddressCode == 0x80 || e.AddressCode == 0x88)
            {
                foreach (byte _byteChar in e.Data)
                {
                    //Printable ascii charaters
                    if (_byteChar >= 32 || _byteChar <= 126)
                    {
                        _strLine1 += Convert.ToChar(_byteChar);
                    }
                    else
                    {
                        //Non printable charaters get set to the binaray thing
                        _strLine1 += '\\' + _byteChar.ToString().PadLeft(3, '0');
                    }
                }
                //Update the text box
                this.TSCTextbox(txtLine1, _strLine1);
            }

            //Checking for the address Ranges we want
            if (e.AddressCode == 0xC0 || e.AddressCode == 0xC8)
            {
                foreach (byte _byteChar in e.Data)
                {
                    //Printable ascii charaters
                    if (_byteChar >= 32 || _byteChar <= 126)
                    {
                        _strLine2 += Convert.ToChar(_byteChar);
                    }
                    else
                    {
                        //Non printable charaters get set to the binaray thing
                        _strLine2 += '\\' + _byteChar.ToString().PadLeft(3, '0');
                    }
                }
                //Update the text box
                this.TSCTextbox(txtLine2, _strLine2);
            }
        }

        void _genericDisplay_ReportingAndStatus(object sender, CFAReportingAndStatusEventArgs e)
        {
            this.TSCHSB(hsbContrast, e.Contrast);
            this.TSCHSB(hsbBacklight, e.Backlight);
        }

        void _genericDisplay_ReportingAndStatus(object sender)
        {
        }

        void TSCHSB(HScrollBar HSB, int Value)
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { TSCHSB(HSB, Value); }));
            }
            else
            {
                HSB.Value = Value;
                if (HSB == hsbBacklight)
                {
                    lblBacklightPercent.Text = Value.ToString() + "%";
                }
                if (HSB == hsbContrast)
                {
                    lblContrastPercent.Text = Value.ToString();
                }
            }
        }

        void TSCTextbox(TextBox TXTBox, string Text)
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { TSCTextbox(TXTBox, Text); }));
            }
            else
            {
                TXTBox.Text = Text;
            }
        }


        void _genericDisplay_HardwareFirmwareVersion(object sender, CFAHardwareFirmwareEventArgs e)
        {
            this.TSCTextbox(txtStatus, e.Information);
        }

        private void btnLine1Send_Click(object sender, EventArgs e)
        {
            _genericDisplay.WriteLine(0, txtLine1.Text, 0, true);
        }

        private void btnLine2Send_Click(object sender, EventArgs e)
        {
            _genericDisplay.WriteLine(1, txtLine2.Text, 0, true);
        }

        private void btnLine3Send_Click(object sender, EventArgs e)
        {
            _genericDisplay.WriteLine(2, txtLine3.Text, 0, true);
        }

        private void btnLine4Send_Click(object sender, EventArgs e)
        {
            _genericDisplay.WriteLine(3, txtLine4.Text, 0, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //We want to dispose of the Display Class
            //If you DO NOT DISPOSE the program will remain running as
            //The class will always have an active thread.
            _genericDisplay.Dispose();

            this.Close();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            new frmDemo(_genericDisplay).Show();
        }

        private void btnPacketDebugger_Click(object sender, EventArgs e)
        {
            new frmPacketDebugger(_genericDisplay).Show();
        }

        private void hsbContrast_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                _genericDisplay.SetContrast(e.NewValue);
            }
        }

        private void hsbBacklight_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                _genericDisplay.SetBacklight(e.NewValue);
                lblBacklightPercent.Text = e.NewValue.ToString() + "%";
            }
        }

        private void btnFans_Click(object sender, EventArgs e)
        {
            new frmFans(_genericDisplay).Show();
        }
    }
}
