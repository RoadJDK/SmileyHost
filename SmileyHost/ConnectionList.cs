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

namespace SmileyHost
{
    public partial class ConnectionList : Form
    {
        private List<IPEndPoint> _clients;
        TcpListener _server;

        private bool _firstUse = true;

        public ConnectionList()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _clients = new List<IPEndPoint>();
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
            ServerStart.Visible = true;
            _server.Stop();
            this.Hide();
            var dashboard = new Dashboard(_clients[0]);
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
                _firstUse = false;
                Run();
            }
        }

        private void Run()
        {
            StartServerAsync();
        }

        private void StartServerAsync()
        {
            Log("Server started");
            var thread = new Thread(() =>
            {
                try
                {
                    var ipAddress = IPAddress.Any;
                    _server = new TcpListener(ipAddress, 65535);
                    _server.Start();
                    Log("Server started");

                    while (true)
                    {
                        while (!_server.Pending())
                        {
                            Thread.Sleep(1000);
                        }

                        using (var client = _server.AcceptTcpClient())
                        {

                            if (!Ping(client))
                            {
                                _clients.Add((IPEndPoint)client.Client.RemoteEndPoint);
                                Log("add client...");
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    Log("error starting the server");
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private bool Ping(TcpClient client)
        {
            var pingSender = new Ping();

            var address = ((IPEndPoint)client.Client.RemoteEndPoint).Address;
            var reply = pingSender.Send(address);

            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }

        private void Log(string text)
        {
            Console.WriteLine(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServerStart.Visible = true;
                _server.Stop();
                this.Hide();
                var dashboard = new Dashboard(_clients[1]);
                dashboard.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("Client not online");
            }
        }
    }
}
