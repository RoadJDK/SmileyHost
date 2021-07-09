using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileyHost.Objects
{
    class ConnectionPanel : Panel
    {
        private int _id;
        private string _name;

        public ConnectionPanel(int id, string name)
        {
            _id = id;
            _name = name;
            this.Size = new Size(650, 390);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new Point(304, 43);
            AddControls(name);
        }

        private void AddControls(string name)
        {
            var labelName = new Label
            {
                Size = new Size(55, 18),
                Location = new Point(17, 20),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "Name:"
            };
            var Name = new Label
            {
                Size = new Size(100, 18),
                Location = new Point(110, 20),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = name
            };
            var labelStatus = new Label
            {
                Size = new Size(55, 18),
                Location = new Point(17, 60),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "Status:"
            };
            var Status = new Label
            {
                Size = new Size(50, 18),
                Location = new Point(110, 60),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.Tomato,
                Text = "Offline"
            };
            var labelIp = new Label
            {
                Size = new Size(25, 18),
                Location = new Point(17, 100),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "IP:"
            };
            var Ip = new Label
            {
                Size = new Size(100, 18),
                Location = new Point(110, 100),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.Aqua,
                Text = "192.168.0.0"
            };
            var labelLastOnline = new Label
            {
                Size = new Size(90, 18),
                Location = new Point(17, 140),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "Last Online:"
            };
            var LastOnline = new Label
            {
                Size = new Size(150, 18),
                Location = new Point(110, 140),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "09.07.2021 02:11"
            };
            var DashboardButton = new Label
            {
                Size = new Size(132, 20),
                Location = new Point(356, 193),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "Go to Dashboard"
            };
            var Preview = new Panel()
            {
                Size = new Size(270,160),
                Location = new Point(360, 20),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(labelName);
            this.Controls.Add(Name);
            this.Controls.Add(labelStatus);
            this.Controls.Add(labelIp);
            this.Controls.Add(Status);
            this.Controls.Add(Ip);
            this.Controls.Add(labelLastOnline);
            this.Controls.Add(LastOnline);
            this.Controls.Add(Preview);
            this.Controls.Add(DashboardButton);

            DashboardButton.Click += DashBoardClick;
        }

        private void DashBoardClick(object sender, EventArgs e)
        {
            MessageBox.Show("I am a dashboard with the ID: " + _id);
            var parentForm = (Form)this.Parent;
            var dashboard = new Dashboard
            {
                Location = parentForm.Location,
                StartPosition = FormStartPosition.Manual
            };
            dashboard.FormClosing += delegate { parentForm.Show();
                parentForm.Location = dashboard.Location;
            };
            dashboard.Show();
            parentForm.Hide();
        }
    }
}
