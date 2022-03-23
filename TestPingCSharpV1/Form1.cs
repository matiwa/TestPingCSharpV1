using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace TestPingCSharpV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPing_Click(object sender, EventArgs e)
        {
            if (txtAddressOrWWW.Text.Length > 0)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(txtAddressOrWWW.Text, 1000);
                    MessageBox.Show(reply.Status.ToString());
                }catch(Exception nie)
                {
                    MessageBox.Show("Wrong IP Address or WWW");
                }                
            }
            else if (txtAddressOrWWW.Text.Length == 0)
                MessageBox.Show("Enter the IP Address or WWW");
        }

        private void txtAddressOrWWW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13) BPing_Click(sender, e);
        }
    }
}
