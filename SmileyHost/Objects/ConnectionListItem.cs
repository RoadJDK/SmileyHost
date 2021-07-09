using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileyHost.Objects
{
    class ConnectionListItem : Panel
    {
        private int _id;
        private string _name;

        public ConnectionListItem(int id, string name)
        {
            _id = id;
            _name = name;
            this.Size = new Size(230, 75);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new Point(10, (id * 75) + (id * 10 + 10));
            this.Click += ConnectionClick;
            AddControls(id, name);
        }

        private void ConnectionClick(object sender, EventArgs e)
        {
            foreach (var item in this.Parent.Controls.OfType<ConnectionListItem>())
            {
                item.BackColor = Color.FromArgb(41, 44, 51);
            }
            this.BackColor = Color.FromArgb(66, 70, 79);
            foreach (var item in this.Parent.Parent.Controls.OfType<ConnectionPanel>())
            {
                this.Parent.Parent.Controls.Remove(item);
            }
            this.Parent.Parent.Controls.Add(new ConnectionPanel(_id, _name));

        }

        private void AddControls(int id, string name)
        {
            var labelId = new Label
            {
                Size = new Size(35, 18),
                Location = new Point(5, 7),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = (id+1).ToString()
            };
            var labelName = new Label
            {
                Size = new Size(85, 18),
                Location = new Point(5, 25),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.White,
                Text = name
            };
            var Status = new Label
            {
                Size = new Size(50, 18),
                Location = new Point(3, 43),
                Font = new Font("Microsoft Sans Serif", 11),
                ForeColor = Color.Tomato,
                Text = "Offline"
            };
            this.Controls.Add(labelId);
            this.Controls.Add(labelName);
            this.Controls.Add(Status);
        }
    }
}
