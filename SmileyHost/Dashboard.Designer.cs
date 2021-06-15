
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
            this.ServerStart = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Display = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.LogOutput.Location = new System.Drawing.Point(21, 43);
            this.LogOutput.Multiline = true;
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.ReadOnly = true;
            this.LogOutput.Size = new System.Drawing.Size(251, 392);
            this.LogOutput.TabIndex = 0;
            // 
            // Screenshot
            // 
            this.Screenshot.AutoSize = true;
            this.Screenshot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenshot.ForeColor = System.Drawing.Color.White;
            this.Screenshot.Location = new System.Drawing.Point(366, 453);
            this.Screenshot.Name = "Screenshot";
            this.Screenshot.Size = new System.Drawing.Size(96, 21);
            this.Screenshot.TabIndex = 8;
            this.Screenshot.Text = "Screenshot";
            this.Screenshot.Click += new System.EventHandler(this.Screenshot_Click);
            // 
            // ServerStart
            // 
            this.ServerStart.AutoSize = true;
            this.ServerStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStart.ForeColor = System.Drawing.Color.White;
            this.ServerStart.Location = new System.Drawing.Point(17, 453);
            this.ServerStart.Name = "ServerStart";
            this.ServerStart.Size = new System.Drawing.Size(100, 21);
            this.ServerStart.TabIndex = 9;
            this.ServerStart.Text = "Start Server";
            this.ServerStart.Click += new System.EventHandler(this.ServerStart_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "SmileyHost Dashboard :^)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Freeze";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(965, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.ServerStart);
            this.Controls.Add(this.Screenshot);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.LogOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "SmileyHost";
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
        private System.Windows.Forms.Label ServerStart;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

