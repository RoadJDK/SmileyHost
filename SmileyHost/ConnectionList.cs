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
            List.HorizontalScroll.Maximum = 0;
            List.AutoScroll = false;
            List.VerticalScroll.Visible = false;
            List.AutoScroll = true;
        }

        private void ServerStart_Click(object sender, EventArgs e)
        {
            List.Controls.Add(new ConnectionListItem(0, "Hello1"));
            List.Controls.Add(new ConnectionListItem(1, "Hello2"));
            List.Controls.Add(new ConnectionListItem(2, "Hello3"));
            List.Controls.Add(new ConnectionListItem(3, "Hello4"));
            List.Controls.Add(new ConnectionListItem(4, "Hello5"));
            List.Controls.Add(new ConnectionListItem(5, "Hello6"));
            List.Controls.Add(new ConnectionListItem(6, "Hello7"));
            List.Controls.Add(new ConnectionListItem(7, "Hello8"));
            List.Controls.Add(new ConnectionListItem(8, "Hello9"));
            List.Controls.Add(new ConnectionListItem(9, "Hello10"));
            List.Controls.Add(new ConnectionListItem(10, "Hello11"));
            List.Controls.Add(new ConnectionListItem(11, "Hello12"));
            List.Controls.Add(new ConnectionListItem(12, "Hello13"));
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
