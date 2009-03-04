using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

using Crystalfontz.Displays;

namespace Demo
{
    public partial class frmSelector : Form
    {
        frmMain _demoForm;

        public frmSelector()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch(cmbSelect.Text)
            {
                case "CFA631":
                    _demoForm = new frmMain(DeviceID.CFA631);
                    _demoForm.Show();
                    break;
                case "CFA633":
                    _demoForm = new frmMain(DeviceID.CFA633);
                    _demoForm.Show();
                    break;
                case "CFA635":
                    _demoForm = new frmMain(DeviceID.CFA635);
                    _demoForm.Show();
                    break;
            }
            this.Hide();
            Thread _disposeChecker = new Thread(this.formClosedCheck);
            _disposeChecker.Start();
        }

        /// <summary>
        /// This is a slick way to spawn a form and still close the previous form when the one spawned closes with out doing something drastic
        /// Drastic as in find procress and close.
        /// </summary>
        private void formClosedCheck()
        {
            while (_demoForm.IsDisposed == false)
            {

                //I find 250ms is a good number to not ping the cpu
                Thread.Sleep(250);
            }

            //Once the demoForm is disposed of we dispose of our selfs
            //Note we need to check to see what thread we are on!
            this.closeForm();
        }

        private void closeForm()
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { closeForm(); }));
            }
            else
            {
                this.Close();
            }
        }
    }
}
