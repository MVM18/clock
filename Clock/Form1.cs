using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private ClockControl clockControl;
        private TimerControl timerControl;
        private AlarmControl alarmControl;
        private StopwatchControl stopwatchControl;
        List<TimerControl> savedTimers = new List<TimerControl>();



        public Form1()
        {
            InitializeComponent();
            clockControl = new ClockControl();
            timerControl = new TimerControl();
            alarmControl = new AlarmControl();
            stopwatchControl = new StopwatchControl();


            ShowUserControl(clockControl);

        }
        private void ShowUserControl(UserControl control)
        {
            panelContainer.Controls.Clear(); // Clear previous controls
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);

            if (control == timerControl)
            {
                // Populate the flowLayoutPanelTimers with existing timers
                flowLayoutPanelTimers.Controls.Clear(); // Prevent duplication
                foreach (var timer in savedTimers)
                {
                    flowLayoutPanelTimers.Controls.Add(timer); // Re-add existing timers
                }
                panelContainer.Controls.Add(flowLayoutPanelTimers);
                flowLayoutPanelTimers.BringToFront();
            }

        }


        private void menuTimer_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // Remove any previously shown controls


            // Refresh timers
            flowLayoutPanelTimers.Controls.Clear(); // Prevent duplication

            foreach (var timer in savedTimers)
            {
                flowLayoutPanelTimers.Controls.Add(timer); // Re-add existing timers
            }
            panelContainer.Controls.Add(flowLayoutPanelTimers); // Show the panel for timers

        }

        private void menuClock_Click(object sender, EventArgs e)
        {

            ShowUserControl(clockControl);
        }

        private void menuAlarm_Click(object sender, EventArgs e)
        {
            ShowUserControl(alarmControl);
        }

        private void menuStopwatch_Click(object sender, EventArgs e)
        {
            ShowUserControl(stopwatchControl);
        }

        private void RemoveTimer(object sender, TimerControl timerControl)
        {
            // Remove the timer from the FlowLayoutPanel

            timerControl.DeleteRequested -= RemoveTimer; // Unsubscribe from the event
            timerControl.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open TimerEditor to create a new timer
            TimerEditor editor = new TimerEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                // Create a new TimerControl instance
                TimerControl newTimer = new TimerControl(editor.Hours, editor.Minutes, editor.Seconds, editor.TimerName);
                newTimer.DeleteRequested += RemoveTimer; // Subscribe to the DeleteRequested event
                newTimer.Dock = DockStyle.Top;  // Ensures stacking behavior
                newTimer.BringToFront();
                savedTimers.Add(newTimer);

                // Add the new timer to a container (e.g., FlowLayoutPanel)
                flowLayoutPanelTimers.Controls.Add(newTimer);
                flowLayoutPanelTimers.Refresh();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
