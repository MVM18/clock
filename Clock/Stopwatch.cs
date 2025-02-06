using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class StopwatchControl : UserControl
    {
        private DateTime startTime;
        private bool isRunning;
        private TimeSpan elapsedTime;
        public StopwatchControl()
        {
            InitializeComponent();
            InitializeStopwatch();

        }
        private void InitializeStopwatch()
        {
            // Initialize stopwatch state
            isRunning = false;
            elapsedTime = TimeSpan.Zero;

            // Configure the timer
            timer1.Interval = 10; // Update every 10 milliseconds
            timer1.Tick += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Update the elapsed time and display it
            elapsedTime = DateTime.Now - startTime;
            lblTime.Text = elapsedTime.ToString(@"hh\:mm\:ss\.fff");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                startTime = DateTime.Now - elapsedTime;
                timer1.Start();
                btnStart.Text = "Stop";
                isRunning = true;
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "Start";
                isRunning = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the stopwatch
            timer1.Stop();
            elapsedTime = TimeSpan.Zero;
            lblTime.Text = "00:00:00.000";
           
            isRunning = false;
        }
    }
}
