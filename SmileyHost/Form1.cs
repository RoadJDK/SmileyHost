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
            _overlay = new PictureBox();
            _overlay.Location = pictureBox1.Location;
            _overlay.Size = pictureBox1.Size;
            _overlay.Hide();
            _overlay.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(_overlay);
            this.Controls.SetChildIndex(_overlay, 0);
        }

        private void Log(string text)
        {
            if (ControlInvokeRequired(textBox1, () => Log(text))) return;
            Console.WriteLine(text);
            textBox1.AppendText(text);
            textBox1.AppendText(Environment.NewLine);
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_running)
            {
                pictureBox1.Image.Save(DateTime.Now.Ticks.ToString("D19") + ".png", ImageFormat.Png);
            }
            else
            {
                _overlay.Image.Save(DateTime.Now.Ticks.ToString("D19") + ".png", ImageFormat.Png);
            }
        }

        void DoWorkTimer()
        {
            _timer.Interval = TimeSpan.FromMilliseconds(10);
            _timer.Tick += _timer_Tick;
        }


        void _timer_Tick(object sender, EventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
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
                pictureBox1.Image = returnImage;
                nNetStream.Close();
            }
            catch (Exception)
            {
                Log("Connection lost");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                Log("Connected...");
                _overlay.Hide();
                _running = true;
                _timer.IsEnabled = true;
            }
            else
            {
                Log("Stopping all threads...");
                _overlay.Image = pictureBox1.Image;
                _overlay.Show();
                _running = false;
                _timer.IsEnabled = false;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var ipAddress = IPAddress.Parse("127.0.0.1");
                using (var client = new TcpClient())
                {
                    client.Connect(ipAddress, 25565);

                    Recieve(client);
                }
            }
            catch (Exception)
            {
                Log("Server not operating");
            }
        }
    }
}
