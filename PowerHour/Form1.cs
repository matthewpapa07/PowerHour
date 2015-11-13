using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PowerHour
{
    public partial class Form1 : Form
    {
        private Timer _Timer = new Timer();
        int minutes = 60;
        int seconds = 60;
        bool paused = true;
        bool started = false;

        const int VK_NEXT_TRACK = 0xB0;
        const int VK_PLAY_PAUSE = 0xB3;
        const int WM_KEYDOWN = 0x0100;

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Timer.Interval = 1000;
            _Timer.Tick += new EventHandler(EverySecond);
            _Timer.Start();
        }

        void EverySecond(object sender, EventArgs e)
        {
            minutesremaining.Text = minutes.ToString() + " Minutes Remaining";
            textclock.Text = seconds.ToString() + " Seconds";

            if (!paused)
            {
                if (seconds > 0)
                {
                    seconds--;
                }
                else
                {
                    seconds = 60;
                    if (minutes > 0)
                    {
                        minutes--;
                        EveryMinute();
                    }
                    else
                    {
                        minutes = 60;
                        paused = true;
                    }
                }
            }
        }

        public void EveryMinute()
        {
            playSiren();
            NextTrack();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            paused = true;
            PlayPause();
        }

        private void button_start_resume_Click(object sender, EventArgs e)
        {
            if (started == false)
            {
                minutes = 60;
                minutes = Int32.Parse(minutestoplay.Text);
                started = true;
                PlayPause();
                playSiren();
                NextTrack();
            }
            else
            {
                PlayPause();
            }
            paused = false;


        }

        private void playSiren()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = Properties.Resources.Siren;

            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }


        private void NextTrack()
        {
            keybd_event((byte)VK_NEXT_TRACK, 0, 1 | 0, 0);
        }

        private void PlayPause()
        {
            keybd_event((byte)VK_PLAY_PAUSE, 0, 1 | 0, 0);
        }
    }
}
