using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SmileyHost
{
    public partial class Form1 : Form
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();

        private bool _running;
        private PictureBox _overlay;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoWorkTimer();
            _overlay = new PictureBox
            {
                Location = Display.Location,
                Size = Display.Size
            };
            _overlay.Hide();
            _overlay.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(_overlay);
            this.Controls.SetChildIndex(_overlay, 0);
        }

        private void Log(string text)
        {
            if (ControlInvokeRequired(LogOutput, () => Log(text))) return;
            Console.WriteLine(text);
            LogOutput.AppendText(text);
            LogOutput.AppendText(Environment.NewLine);
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }

        void DoWorkTimer()
        {
            _timer.Interval = TimeSpan.FromMilliseconds(10);
            _timer.Tick += _timer_Tick;
        }


        void _timer_Tick(object sender, EventArgs e)
        {
            var worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
            worker.CancelAsync();
            worker.Dispose();
        }

        private void Recieve(TcpClient client)
        {
            try
            {
                var nNetStream = client.GetStream();

                var returnImage = Image.FromStream(nNetStream);
                Display.Image = returnImage;
                nNetStream.Close();
            }
            catch (Exception)
            {

            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var ipAddress = IPAddress.Parse("192.168.0.0"); //ip
                using (var client = new TcpClient())
                {
                    client.Connect(ipAddress, 65535);
                    
                    Recieve(client);
                }
            }
            catch (Exception)
            {

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
            this.Close();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                _overlay.Hide();
                _running = true;
                _timer.IsEnabled = true;
            }
            else
            {
                _overlay.Image = Display.Image;
                _overlay.Show();
                _running = false;
                _timer.IsEnabled = false;
            }
        }

        private void START_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
