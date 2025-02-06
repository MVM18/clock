using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clock
{
    public partial class TimerControl : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private int timeRemaining;
        private int hours, minutes, seconds;
        public event EventHandler<TimerControl> DeleteRequested; // To notify parent form
       
        public TimerControl(int hours = 0, int minutes = 1, int seconds = 0, string name = "New Timer")
        {
            InitializeComponent();
            InitializeTimerControl();

            this.hours = Math.Max(0, Math.Min(23, hours));
            this.minutes = Math.Max(0, Math.Min(59, minutes));
            this.seconds = Math.Max(0, Math.Min(59, seconds));
            lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            lblTimerName.Text = name; // Assuming you have a label for the timer name
           

        }

        private void InitializeTimerControl()
        {
            // Timer setup
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }

        // Timer Tick - Countdown
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                lblTime.Text = TimeSpan.FromSeconds(timeRemaining).ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is up!", "Timer");
                btnStart.Text = "Start";
            }
        }

        private void TimerControl_Load(object sender, EventArgs e)
        {
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

            timer.Stop();
            lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            btnStart.Text = "Start";
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timeRemaining = (hours * 3600) + (minutes * 60) + seconds; // Convert to seconds
                timer.Start();
                btnStart.Text = "Pause";
            }
            else
            {
                timer.Stop();
                btnStart.Text = "Start";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open TimerEditorForm with existing values
            TimerEditor editor = new TimerEditor(hours, minutes, seconds, lblTimerName.Text);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                // Update values from editor
                hours = editor.Hours;
                minutes = editor.Minutes;
                seconds = editor.Seconds;
                lblTimerName.Text = editor.TimerName;
                lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            else if (editor.DialogResult == DialogResult.Abort) // If delete was pressed
            {
                DeleteRequested?.Invoke(this, this);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
