
namespace SmileyHost
{
    partial class ConnectionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionList));
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Panel();
            this.ServerStart = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "SmileyHost List :^)";
            // 
            // List
            // 
            this.List.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List.Location = new System.Drawing.Point(21, 43);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(250, 390);
            this.List.TabIndex = 0;
            // 
            // ServerStart
            // 
            this.ServerStart.AutoSize = true;
            this.ServerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStart.ForeColor = System.Drawing.Color.White;
            this.ServerStart.Location = new System.Drawing.Point(17, 450);
            this.ServerStart.Name = "ServerStart";
            this.ServerStart.Size = new System.Drawing.Size(94, 20);
            this.ServerStart.TabIndex = 13;
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
            // ConnectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(965, 505);
            this.Controls.Add(this.ServerStart);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionList";
            this.Text = "SmileyHost";
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Label ServerStart;
    }
}

