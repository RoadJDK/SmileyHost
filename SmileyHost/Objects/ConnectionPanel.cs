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
        public ConnectionPanel(int id, string name)
        {
            this.Size = new Size(230, 75);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new Point(10, (id * 75) + (id * 10 + 10));
            AddLabels(id,name);
        }

        private void AddLabels(int id, string name)
        {
            var labelId = new Label
            {
                Size = new Size(35, 18),
                Location = new Point(5, 7),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = id.ToString()
            };
            var labelName = new Label
            {
                Size = new Size(85, 18),
                Location = new Point(5, 25),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = name
            };
            var labelStatus = new Label
            {
                Size = new Size(54, 18),
                Location = new Point(3, 43),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = "Status:"
            };
            var Status = new Label
            {
                Size = new Size(50, 18),
                Location = new Point(54, 43),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.Tomato,
                Text = "Offline"
            };
            this.Controls.Add(labelId);
            this.Controls.Add(labelName);
            this.Controls.Add(labelStatus);
            this.Controls.Add(Status);
        }
    }
}
