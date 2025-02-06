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
    public partial class ClockControl : UserControl
    {
        private System.Windows.Forms.Timer timer;

        public ClockControl()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            this.Controls.Add(lblTime);

            // Create and configure the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();

            // Set initial time
            UpdateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {

        }
    }
}
