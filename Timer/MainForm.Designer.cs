﻿namespace Timer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbSecond = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbHour.Location = new System.Drawing.Point(36, 105);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(54, 28);
            this.cbHour.TabIndex = 0;
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinute.Location = new System.Drawing.Point(154, 105);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(54, 28);
            this.cbMinute.TabIndex = 1;
            // 
            // cbSecond
            // 
            this.cbSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecond.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.cbSecond.FormattingEnabled = true;
            this.cbSecond.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbSecond.Location = new System.Drawing.Point(282, 105);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(54, 28);
            this.cbSecond.TabIndex = 2;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(96, 112);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 16);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(214, 112);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 16);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "Minute";
            this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(342, 112);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(61, 16);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "Second";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(111, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 34);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Nice Timer";
            // 
            // btnLogoff
            // 
            this.btnLogoff.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogoff.Location = new System.Drawing.Point(155, 162);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(121, 38);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Log off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnShutdown.Location = new System.Drawing.Point(155, 206);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(121, 38);
            this.btnShutdown.TabIndex = 11;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnResume.Location = new System.Drawing.Point(155, 250);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(121, 38);
            this.btnResume.TabIndex = 14;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblText.Location = new System.Drawing.Point(33, 72);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 17);
            this.lblText.TabIndex = 16;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemain.ForeColor = System.Drawing.Color.Crimson;
            this.lblRemain.Location = new System.Drawing.Point(294, 72);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(0, 17);
            this.lblRemain.TabIndex = 17;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPause.Location = new System.Drawing.Point(28, 250);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 38);
            this.btnPause.TabIndex = 20;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHibernate.Location = new System.Drawing.Point(28, 206);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(121, 38);
            this.btnHibernate.TabIndex = 19;
            this.btnHibernate.Text = "Hibernate";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLock.Location = new System.Drawing.Point(28, 162);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(121, 38);
            this.btnLock.TabIndex = 18;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(283, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 38);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRestart.Location = new System.Drawing.Point(283, 206);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 38);
            this.btnRestart.TabIndex = 22;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSleep.Location = new System.Drawing.Point(283, 162);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(121, 38);
            this.btnSleep.TabIndex = 21;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHibernate);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.cbSecond);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbSecond;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Timer timer;
    }
}