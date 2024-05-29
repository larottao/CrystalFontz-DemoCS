using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Crystalfontz.Displays;

namespace Demo
{
    public partial class frmDemo : Form
    {
        CFA63XDisplay _display;

        ScrollingText _scrollText;

        public frmDemo(CFA63XDisplay Display)
        {
            InitializeComponent();
            _display = Display;
        }

        private void btnProgDemo1_Click(object sender, EventArgs e)
        {
            LCDProgressBar _progressBar = new LCDProgressBar(_display);
            _progressBar.Demo1();
        }

        private void btnProgDemo2_Click(object sender, EventArgs e)
        {
            LCDProgressBar _progressBar = new LCDProgressBar(_display);
            _progressBar.Demo2();
        }

        private void btnScrollDemo_Click(object sender, EventArgs e)
        {
            _scrollText = new ScrollingText(_display);
            
            //Set the text we wish to scroll
            _scrollText.Text = "Now Playing: [The Demo Song] By: [The Demo Team]";

            //Set the padding (The Space from the end of the string back to the start)
            _scrollText.PadString = 5;

            //you could use the default oddly is 750 :)
            _scrollText.ScrollSpeed = 750;

            //Start the Scroll
            _scrollText.StartScroll();

            //Enable/Disable Button
            btnScrollDemo.Enabled = false;
            btnStopScroll.Enabled = true;
        }

        private void btnStopScroll_Click(object sender, EventArgs e)
        {
            //Stop the Scrolling :)
            _scrollText.StopScroll(true);

            //Enable/Disable Button
            btnScrollDemo.Enabled = true;
            btnStopScroll.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the Form
            this.Close();
        }
    }
}
