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
    public partial class frmFans : Form
    {
        CFA63XDisplay _display;
        SCAB _scab;

        public frmFans(CFA63XDisplay Display)
        {
            InitializeComponent();
            _display = Display;
            _scab = new SCAB(_display);
            _scab.FanReport += new SCAB.FanReportHandler(_scab_FanReport);
            _scab.QueryFanPower += new SCAB.QueryFanPowerHandler(_scab_QueryFanPower);
        }

        void _scab_QueryFanPower(object sender, CFAQueryFanEventArgs e)
        {
            if (chkFan1.Checked)
            {
                this.TSCScroll(vsFan1, 100 - e.Fan1);
            }
        }

        void _scab_FanReport(object sender, CFAFanReportEventArgs e)
        {
            if (chkFan1.Checked)
            {
                if (e.Index == 0)
                {
                    this.TSCLabel(lblRPMSFan1, e.RPMS.ToString() + " RPM");
                }
            }
            if (chkFan2.Checked)
            {
                if (e.Index == 1)
                {
                    this.TSCLabel(lblRPMSFan2, e.RPMS.ToString() + " RPM");
                }
            }
            if (chkFan3.Checked)
            {
                if (e.Index == 2)
                {
                    this.TSCLabel(lblRPMSFan3, e.RPMS.ToString() + " RPM");
                }
            }
            if (chkFan4.Checked)
            {
                if (e.Index == 3)
                {
                    this.TSCLabel(lblRPMSFan4, e.RPMS.ToString() + " RPM");
                }
            }
        }

        void TSCScroll(VScrollBar Scroll, int Value)
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { TSCScroll(Scroll, Value); }));
            }
            else
            {
                Scroll.Value = Value;
                lblFan1Power.Text = (100-Value).ToString() + "%";
            }
        }


        void TSCLabel(Label LBL, string Text)
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { TSCLabel(LBL, Text); }));
            }
            else
            {
                LBL.Text = Text;
            }
        }

        private void chkFan1_CheckedChanged(object sender, EventArgs e)
        {
            _scab.QueryFanPowerAndFailSafe();
        }

        private void vsFan1_Scroll(object sender, ScrollEventArgs e)
        {
            lblFan1Power.Text = (100 - e.NewValue).ToString() + "%";
            _scab.SetUpFanPower(Convert.ToByte(100 - e.NewValue), Convert.ToByte(100 - vsFan2.Value), Convert.ToByte(100 - vsFan3.Value), Convert.ToByte(100 - vsFan4.Value));
        }

        private void vsFan2_Scroll(object sender, ScrollEventArgs e)
        {
            lblFan2Power.Text = (100 - e.NewValue).ToString() + "%";
            _scab.SetUpFanPower(Convert.ToByte(100 - vsFan1.Value), Convert.ToByte(100 - e.NewValue), Convert.ToByte(100 - vsFan3.Value), Convert.ToByte(100 - vsFan4.Value));
        }

        private void vsFan3_Scroll(object sender, ScrollEventArgs e)
        {
            lblFan3Power.Text = (100 - e.NewValue).ToString() + "%";
            _scab.SetUpFanPower(Convert.ToByte(100 - vsFan1.Value), Convert.ToByte(100 - vsFan2.Value), Convert.ToByte(100 - e.NewValue), Convert.ToByte(100 - vsFan4.Value));
        }

        private void vsFan4_Scroll(object sender, ScrollEventArgs e)
        {
            lblFan4Power.Text = (100 - e.NewValue).ToString() + "%";
            _scab.SetUpFanPower(Convert.ToByte(100 - vsFan1.Value), Convert.ToByte(100 - vsFan2.Value), Convert.ToByte(100 - vsFan3.Value), Convert.ToByte(100 - e.NewValue));
        }
    }
}
