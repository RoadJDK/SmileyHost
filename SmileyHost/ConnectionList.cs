using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmileyHost.Objects;

namespace SmileyHost
{
    public partial class ConnectionList : Form
    {

        public ConnectionList()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {

        }

        private void ServerStart_Click(object sender, EventArgs e)
        {
            List.Controls.Add(new ConnectionPanel(0, "hello"));
            List.Controls.Add(new ConnectionPanel(1, "hello2"));
            List.Controls.Add(new ConnectionPanel(2, "hello3"));
            List.Controls.Add(new ConnectionPanel(3, "hello4"));
            List.Controls.Add(new ConnectionPanel(4, "hello5"));
            ServerStart.Hide();
        }
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
