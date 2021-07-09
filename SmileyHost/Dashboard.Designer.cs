
namespace SmileyHost
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.LogOutput = new System.Windows.Forms.TextBox();
            this.Screenshot = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.Freeze = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelIP = new System.Windows.Forms.Label();
            this.ClientIP = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Display = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.ClientLocation = new System.Windows.Forms.Label();
            this.ClientStatus = new System.Windows.Forms.Label();
            this.LabelLastOnline = new System.Windows.Forms.Label();
            this.ClientLastOnline = new System.Windows.Forms.Label();
            this.Shell = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutput
            // 
            this.LogOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LogOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogOutput.ForeColor = System.Drawing.Color.White;
            this.LogOutput.Location = new System.Drawing.Point(21, 221);
            this.LogOutput.Multiline = true;
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.ReadOnly = true;
            this.LogOutput.Size = new System.Drawing.Size(251, 214);
            this.LogOutput.TabIndex = 0;
            // 
            // Screenshot
            // 
            this.Screenshot.AutoSize = true;
            this.Screenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenshot.ForeColor = System.Drawing.Color.White;
            this.Screenshot.Location = new System.Drawing.Point(366, 453);
            this.Screenshot.Name = "Screenshot";
            this.Screenshot.Size = new System.Drawing.Size(91, 20);
            this.Screenshot.TabIndex = 8;
            this.Screenshot.Text = "Screenshot";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(17, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(192, 20);
            this.LabelTitle.TabIndex = 11;
            this.LabelTitle.Text = "SmileyHost Dashboard :^)";
            // 
            // Freeze
            // 
            this.Freeze.AutoSize = true;
            this.Freeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freeze.ForeColor = System.Drawing.Color.White;
            this.Freeze.Location = new System.Drawing.Point(300, 453);
            this.Freeze.Name = "Freeze";
            this.Freeze.Size = new System.Drawing.Size(59, 20);
            this.Freeze.TabIndex = 12;
            this.Freeze.Text = "Freeze";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 1);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(21, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(251, 143);
            this.textBox1.TabIndex = 14;
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIP.ForeColor = System.Drawing.Color.White;
            this.LabelIP.Location = new System.Drawing.Point(31, 106);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(23, 16);
            this.LabelIP.TabIndex = 15;
            this.LabelIP.Text = "IP:";
            // 
            // ClientIP
            // 
            this.ClientIP.AutoSize = true;
            this.ClientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIP.ForeColor = System.Drawing.Color.Tomato;
            this.ClientIP.Location = new System.Drawing.Point(153, 106);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(31, 16);
            this.ClientIP.TabIndex = 16;
            this.ClientIP.Text = "N/A";
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::SmileyHost.Properties.Resources.whitearrow1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(21, 441);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(33, 34);
            this.Back.TabIndex = 17;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::SmileyHost.Properties.Resources.whiteminus1;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(903, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(22, 22);
            this.Minimize.TabIndex = 10;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Location = new System.Drawing.Point(931, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(22, 22);
            this.Close.TabIndex = 5;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Display
            // 
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Display.Location = new System.Drawing.Point(304, 43);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(649, 392);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Display.TabIndex = 2;
            this.Display.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(31, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(48, 16);
            this.LabelName.TabIndex = 18;
            this.LabelName.Text = "Name:";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.Color.White;
            this.ClientName.Location = new System.Drawing.Point(153, 55);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(35, 16);
            this.ClientName.TabIndex = 19;
            this.ClientName.Text = "Test";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.White;
            this.LabelStatus.Location = new System.Drawing.Point(31, 80);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(48, 16);
            this.LabelStatus.TabIndex = 21;
            this.LabelStatus.Text = "Status:";
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocation.ForeColor = System.Drawing.Color.White;
            this.LabelLocation.Location = new System.Drawing.Point(31, 131);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(62, 16);
            this.LabelLocation.TabIndex = 20;
            this.LabelLocation.Text = "Location:";
            // 
            // ClientLocation
            // 
            this.ClientLocation.AutoSize = true;
            this.ClientLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.ClientLocation.Location = new System.Drawing.Point(153, 131);
            this.ClientLocation.Name = "ClientLocation";
            this.ClientLocation.Size = new System.Drawing.Size(56, 16);
            this.ClientLocation.TabIndex = 22;
            this.ClientLocation.Text = "Canada";
            // 
            // ClientStatus
            // 
            this.ClientStatus.AutoSize = true;
            this.ClientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientStatus.ForeColor = System.Drawing.Color.Tomato;
            this.ClientStatus.Location = new System.Drawing.Point(153, 80);
            this.ClientStatus.Name = "ClientStatus";
            this.ClientStatus.Size = new System.Drawing.Size(45, 16);
            this.ClientStatus.TabIndex = 23;
            this.ClientStatus.Text = "Offline";
            // 
            // LabelLastOnline
            // 
            this.LabelLastOnline.AutoSize = true;
            this.LabelLastOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastOnline.ForeColor = System.Drawing.Color.White;
            this.LabelLastOnline.Location = new System.Drawing.Point(31, 156);
            this.LabelLastOnline.Name = "LabelLastOnline";
            this.LabelLastOnline.Size = new System.Drawing.Size(77, 16);
            this.LabelLastOnline.TabIndex = 24;
            this.LabelLastOnline.Text = "Last Online:";
            // 
            // ClientLastOnline
            // 
            this.ClientLastOnline.AutoSize = true;
            this.ClientLastOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLastOnline.ForeColor = System.Drawing.Color.White;
            this.ClientLastOnline.Location = new System.Drawing.Point(153, 156);
            this.ClientLastOnline.Name = "ClientLastOnline";
            this.ClientLastOnline.Size = new System.Drawing.Size(104, 16);
            this.ClientLastOnline.TabIndex = 25;
            this.ClientLastOnline.Text = "09.07.2021 02:40";
            // 
            // Shell
            // 
            this.Shell.AutoSize = true;
            this.Shell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shell.ForeColor = System.Drawing.Color.White;
            this.Shell.Location = new System.Drawing.Point(463, 453);
            this.Shell.Name = "Shell";
            this.Shell.Size = new System.Drawing.Size(44, 20);
            this.Shell.TabIndex = 26;
            this.Shell.Text = "Shell";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(965, 505);
            this.Controls.Add(this.Shell);
            this.Controls.Add(this.ClientLastOnline);
            this.Controls.Add(this.LabelLastOnline);
            this.Controls.Add(this.ClientStatus);
            this.Controls.Add(this.ClientLocation);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ClientIP);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Freeze);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Screenshot);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.LogOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "SmileyHost";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogOutput;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label Screenshot;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label Freeze;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.Label ClientIP;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Label ClientLocation;
        private System.Windows.Forms.Label ClientStatus;
        private System.Windows.Forms.Label LabelLastOnline;
        private System.Windows.Forms.Label ClientLastOnline;
        private System.Windows.Forms.Label Shell;
    }
}

