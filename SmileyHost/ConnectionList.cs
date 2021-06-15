using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileyHost
{
    public partial class ConnectionList : Form
    {
        private List<TcpClient> _clients;

        private bool _running;
        private bool _firstUse;

        public ConnectionList()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _clients = new List<TcpClient>();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Dashboard(0);
            dashboard.Show();
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

        private void ServerStart_Click(object sender, EventArgs e)
        {
            if (_firstUse)
            {
                ServerStart.Visible = false;
                _running = true;
                _firstUse = false;
                Run();
            }
        }
    }
}
