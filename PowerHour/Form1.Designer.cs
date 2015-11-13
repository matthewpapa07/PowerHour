namespace PowerHour
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.minutesremaining = new System.Windows.Forms.Label();
            this.minutestoplay = new System.Windows.Forms.TextBox();
            this.panel_started = new System.Windows.Forms.Panel();
            this.button_start_resume = new System.Windows.Forms.Button();
            this.textclock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_started.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "POWER HOUR";
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(221, 314);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(370, 189);
            this.button_pause.TabIndex = 2;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // minutesremaining
            // 
            this.minutesremaining.AutoSize = true;
            this.minutesremaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesremaining.Location = new System.Drawing.Point(56, 31);
            this.minutesremaining.Name = "minutesremaining";
            this.minutesremaining.Size = new System.Drawing.Size(1014, 108);
            this.minutesremaining.TabIndex = 3;
            this.minutesremaining.Text = "60 Minutes Remaining";
            // 
            // minutestoplay
            // 
            this.minutestoplay.Location = new System.Drawing.Point(93, 361);
            this.minutestoplay.Name = "minutestoplay";
            this.minutestoplay.Size = new System.Drawing.Size(21, 20);
            this.minutestoplay.TabIndex = 4;
            this.minutestoplay.Text = "60";
            // 
            // panel_started
            // 
            this.panel_started.Controls.Add(this.label5);
            this.panel_started.Controls.Add(this.label3);
            this.panel_started.Controls.Add(this.button_start_resume);
            this.panel_started.Controls.Add(this.minutestoplay);
            this.panel_started.Controls.Add(this.textclock);
            this.panel_started.Controls.Add(this.button_pause);
            this.panel_started.Controls.Add(this.minutesremaining);
            this.panel_started.Location = new System.Drawing.Point(-2, 0);
            this.panel_started.Name = "panel_started";
            this.panel_started.Size = new System.Drawing.Size(1096, 562);
            this.panel_started.TabIndex = 8;
            // 
            // button_start_resume
            // 
            this.button_start_resume.Location = new System.Drawing.Point(597, 311);
            this.button_start_resume.Name = "button_start_resume";
            this.button_start_resume.Size = new System.Drawing.Size(370, 192);
            this.button_start_resume.TabIndex = 6;
            this.button_start_resume.Text = "Start/Resume";
            this.button_start_resume.UseVisualStyleBackColor = true;
            this.button_start_resume.Click += new System.EventHandler(this.button_start_resume_Click);
            // 
            // textclock
            // 
            this.textclock.AutoSize = true;
            this.textclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textclock.ForeColor = System.Drawing.Color.Red;
            this.textclock.Location = new System.Drawing.Point(265, 139);
            this.textclock.Name = "textclock";
            this.textclock.Size = new System.Drawing.Size(559, 108);
            this.textclock.TabIndex = 4;
            this.textclock.Text = "00 Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Playing for";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "minutes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 558);
            this.Controls.Add(this.panel_started);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POWER HOUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_started.ResumeLayout(false);
            this.panel_started.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label minutesremaining;
        private System.Windows.Forms.TextBox minutestoplay;
        private System.Windows.Forms.Panel panel_started;
        private System.Windows.Forms.Label textclock;
        private System.Windows.Forms.Button button_start_resume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

