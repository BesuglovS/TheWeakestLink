using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWeakestLink
{
    public partial class TimerForm : Form
    {
        private readonly int _seconds;
        private readonly DateTime _finishTime;
        private bool _sizeConfigured;
        private bool _closeOnTimer;

        public TimerForm(int seconds, bool fullScreen, bool closeOnTimer)
        {
            _closeOnTimer = closeOnTimer;
            _seconds = seconds;
            _finishTime = DateTime.Now.AddSeconds(seconds);
            _sizeConfigured = false;

            InitializeComponent();

            MainLabel.BackColor = MainForm.TimerBackgroundColor;
            MainLabel.ForeColor = MainForm.TimerDigitsColor;

            if (fullScreen)
            {
                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            MainTmer.Interval = _seconds*1000;
            MainTmer.Enabled = true;

            RefreshTimer.Interval = 100;
            RefreshTimer.Enabled = true;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            var timeLeft = _finishTime - DateTime.Now;
            var secondsLeft = timeLeft.Seconds;
            var minutesLeft = timeLeft.Minutes;
            

            var timeLeftText = minutesLeft.ToString("00") + ":" + secondsLeft.ToString("00");

            MainLabel.Text = timeLeftText;

            if (_sizeConfigured == false)
            {
                FitLabelInWindow();
                _sizeConfigured = true;
            }
        }

        private void FitLabelInWindow()
        {
            if (TextRenderer.MeasureText(
                MainLabel.Text,
                new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size, MainLabel.Font.Style)).Width <
                MainLabel.Width - 30)
            {

                while (TextRenderer.MeasureText(
                    MainLabel.Text,
                    new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size, MainLabel.Font.Style)).Width
                       < MainLabel.Width - 30)
                {
                    MainLabel.Font = new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size + 1f, MainLabel.Font.Style);
                }
            }

            if (TextRenderer.MeasureText(
                MainLabel.Text,
                new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size, MainLabel.Font.Style)).Width >
                MainLabel.Width - 30)
            {

                while (TextRenderer.MeasureText(
                    MainLabel.Text,
                    new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size, MainLabel.Font.Style)).Width
                       > MainLabel.Width - 30)
                {
                    MainLabel.Font = new Font(MainLabel.Font.FontFamily, MainLabel.Font.Size - 1f, MainLabel.Font.Style);
                }
            }

        }

        private void MainTmer_Tick(object sender, EventArgs e)
        {
            if (_closeOnTimer)
            {
                Close();
            }

            RefreshTimer.Enabled = false;
        }

        private void TimerForm_Resize(object sender, EventArgs e)
        {
            FitLabelInWindow();
        }
    }
}
