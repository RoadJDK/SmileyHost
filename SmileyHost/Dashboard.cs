using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace SmileyHost
{
    public partial class Dashboard : Form
    {
        private Helper _helper;
        private PictureBox _overlay;

        private bool _running;
        private bool _firstUse;

        private int _index;

        public Dashboard(int index)
        {
            InitializeComponent();
            Initialize(index);
        }

        private void Initialize(int index)
        {
            _helper = new Helper();
            _firstUse = true;
            SetOverlay();
            _index = index;
        }

        private void SetOverlay()
        {
            _overlay = new PictureBox
            {
                Location = Display.Location,
                Size = Display.Size,
                BorderStyle = BorderStyle.FixedSingle
            };
            _overlay.Hide();
            _overlay.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(_overlay);
            this.Controls.SetChildIndex(_overlay, 0);
        }

        private void Run()
        {
            StartServerAsync();
        }

        private void StartServerAsync()
        {
            var thread = new Thread(() =>
            {
                try
                {
                    var ipAddress = IPAddress.Any;
                    var server = new TcpListener(ipAddress, 65535);
                    server.Start();
                    Log("Server started");

                    while (true)
                    {
                        while (!server.Pending())
                        {
                            var counter = 1;
                            if (counter % 10 == 0)
                            {
                                Log("no connection yet..");
                                counter = 1;
                            }
                            counter++;

                            Thread.Sleep(1000);
                        }

                        using (var client = server.AcceptTcpClient())
                        {
                            try
                            {
                                var nNetStream = client.GetStream();

                                var returnImage = Image.FromStream(nNetStream);
                                Display.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    Display.Image = returnImage;
                                });
                                nNetStream.Close();
                            }
                            catch (SocketException)
                            {
                                Log("error while connecting to the socket");
                            }
                            catch (Exception)
                            {
                                Log("error while recieving");
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

        private void Log(string text)
        {
            try
            {
                if (_helper.ControlInvokeRequired(LogOutput, () => Log(text))) return;
                Console.WriteLine(text);
                LogOutput.AppendText(text);
                LogOutput.AppendText(Environment.NewLine);
            }
            catch (Exception)
            { }
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

        private void Screenshot_Click(object sender, EventArgs e)
        {
            if (_running)
            {
                Display.Image.Save(DateTime.Now.Ticks.ToString("D19") + ".png", ImageFormat.Png);
            }
            else
            {
                _overlay.Image.Save(DateTime.Now.Ticks.ToString("D19") + ".png", ImageFormat.Png);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                _overlay.Hide();
                _running = true;

            }
            else
            {
                _overlay.Image = Display.Image;
                _overlay.Show();
                _running = false;
            }
        }
    }
}
