using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileyHost
{
    class Helper
    {

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }

        public void RecordDisplay(Form form, PictureBox display, Label label)
        {
            var thread = new Thread(() =>
            {
                try
                {
                    var python = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "C:\\Users\\me\\AppData\\Local\\Programs\\Python\\Python39\\python.exe",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Arguments = string.Format("{0} {1} {2} {3} {4}", "Recorder.py", form.Location.X + display.Location.X,
                                form.Location.Y + display.Location.Y, display.Width, display.Height),
                            RedirectStandardError = true,
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };
                    python.Start();
                    python.WaitForExit();
                    python.Close();

                    Thread.Sleep(500);

                    var process = new Process();
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "ffmpeg.exe");
                    var datetime = DateTime.Now.ToString("yyyyMMdd-HHmmss");

                    process.StartInfo.Arguments = "-f image2 -r 10 -i images/%04d.png -vcodec libx264 -pix_fmt yuv420p -s 1920x1080 -aspect 16:9 -acodec aac " + datetime + ".mp4";

                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    var counter = 1;

                    while (true)
                    {
                        Thread.Sleep(100);
                        if (counter >= 50)
                        {
                            Console.WriteLine("--");
                            break;
                        }

                        Console.WriteLine("++");
                        counter++;
                    }

                }
                finally
                {
                    Directory.Delete(Path.Combine(Environment.CurrentDirectory, "images/"), true);
                    label.BeginInvoke((MethodInvoker)delegate () { label.ForeColor = Color.White; label.Text = "Record"; });
                }
            });
            thread.Start();
        }
    }
}
