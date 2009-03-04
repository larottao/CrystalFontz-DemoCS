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
    public partial class frmPacketDebugger : Form
    {

        CFA63XDisplay _display;

        dsPackets _dsPackets;

        public frmPacketDebugger(CFA63XDisplay Display)
        {
            InitializeComponent();
            _display = Display;

            _dsPackets = new dsPackets();

            dgvPackets.DataSource = _dsPackets.PacketTable;

            dgvPackets.CellValueChanged += new DataGridViewCellEventHandler(dgvPackets_CellValueChanged);


            _display.PacketRecived += new CFA63XDisplay.PacketRecivedHandler(_display_PacketRecived);
            _display.GetHardwareFirmwareVersion();
        }

        void dgvPackets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Check to make sure column is checkbox.
            if (dgvPackets.Columns[e.ColumnIndex].CellType.ToString() == "System.Windows.Forms.DataGridViewCheckBoxCell")
            {
                if (dgvPackets.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    string _data = dgvPackets.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                    List<byte> _listBytes = new List<byte>();
                    foreach (string _strByte in _data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (_strByte.Contains('x'))
                        {
                            //I know seems complexed.
                            //Basicly we remove the '0x' from the string
                            //then we parse into an byte.
                            _listBytes.Add(byte.Parse(_strByte.Substring(2),System.Globalization.NumberStyles.HexNumber));
                        }
                        else
                        {
                            _listBytes.Add(Convert.ToByte(_strByte));
                        }
                    }
                    dgvPackets.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = ASCIIEncoding.ASCII.GetString(_listBytes.ToArray());
                }
            }
        }

        void _display_PacketRecived(object sender, CFAPacket e)
        {
            //Hard coded to ignore the fan report :)
            if (e.Command != 0x1F && e.Command != 0x81)
            {
                writePacket(e);
            }
        }

        private void writePacket(CFAPacket Packet)
        {
            //Check to see if we are on the right thread
            if (this.InvokeRequired)
            {
                //Begin the Invoke, Create the delegate and reinvoke our selfs
                BeginInvoke(new MethodInvoker(delegate() { writePacket(Packet); }));
            }
            else
            {
                dsPackets.PacketTableRow _newRow = _dsPackets.PacketTable.NewPacketTableRow();

                _newRow.AsAscii = false;


                if (chkPacketIDHex.Checked)
                {
                    _newRow.PacketID = "0x" + Packet.Command.ToString("X");
                }
                else
                {
                    _newRow.PacketID = Packet.Command.ToString();
                }



                _newRow.PacketLength = Packet.DataLength;
                

                


                //if (chkPacketIDHex.Checked)
                //{
                //    _item.Text = "0x" + Packet.Command.ToString("X");
                //}
                //else
                //{
                //    _item.Text = Packet.Command.ToString();
                //}


                string _byteData = "";

                foreach (byte _byte in Packet.Data)
                {
                    if (chkPacket.Checked)
                    {
                        _byteData += "0x" + _byte.ToString("X") + " ";
                    }
                    else
                    {
                        _byteData += _byte.ToString() + " ";
                    }
                }

                _newRow.PacketData = _byteData;

                _newRow.CRC = Packet.CRC.ToString();

                _newRow.Timestamp = DateTime.Now.ToLongTimeString();

                _dsPackets.PacketTable.AddPacketTableRow(_newRow);
                //_item.SubItems.Add(_byteData);

                //_item.SubItems.Add(Packet.CRC.ToString());

                //_item.SubItems.Add(DateTime.Now.ToShortTimeString());

                //lstPacket.Items.Add(_item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
