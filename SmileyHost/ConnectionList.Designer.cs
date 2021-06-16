
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
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Panel();
            this.ServerStart = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.Detail.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "SmileyHost List :^)";
            // 
            // Detail
            // 
            this.Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Detail.Controls.Add(this.label7);
            this.Detail.Controls.Add(this.label6);
            this.Detail.Controls.Add(this.pictureBox1);
            this.Detail.Controls.Add(this.label5);
            this.Detail.Controls.Add(this.label4);
            this.Detail.Controls.Add(this.label3);
            this.Detail.Controls.Add(this.label2);
            this.Detail.Location = new System.Drawing.Point(304, 43);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(649, 392);
            this.Detail.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 13;
            // 
            // List
            // 
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List.Controls.Add(this.button2);
            this.List.Controls.Add(this.button1);
            this.List.Location = new System.Drawing.Point(21, 43);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(251, 392);
            this.List.TabIndex = 0;
            // 
            // ServerStart
            // 
            this.ServerStart.AutoSize = true;
            this.ServerStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStart.ForeColor = System.Drawing.Color.White;
            this.ServerStart.Location = new System.Drawing.Point(17, 450);
            this.ServerStart.Name = "ServerStart";
            this.ServerStart.Size = new System.Drawing.Size(100, 21);
            this.ServerStart.TabIndex = 13;
            this.ServerStart.Text = "Start Server";
            this.ServerStart.Click += new System.EventHandler(this.ServerStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(107, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Offline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(356, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Go to Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(360, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 155);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(107, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "N/A";
            // 
            // ConnectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(965, 505);
            this.Controls.Add(this.ServerStart);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionList";
            this.Text = "SmileyHost";
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Detail;
        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ServerStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

