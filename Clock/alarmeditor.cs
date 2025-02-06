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
    public partial class alarmeditor : Form
    {
        public alarmeditor()
        {
            InitializeComponent();
        }

        private void alarmeditor_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }
        private void InitializeControls()
        {
            // Set up AM/PM ListBox
            lstAMPM.Items.Add("AM");
            lstAMPM.Items.Add("PM");
            lstAMPM.SelectedIndex = 0; // Default to AM

            // Set up Snooze ListBox (disabled by default)
            lstSnooze.Items.Add("5 minutes");
            lstSnooze.Items.Add("10 minutes");
            lstSnooze.Items.Add("20 minutes");
            lstSnooze.Items.Add("30 minutes");
            lstSnooze.Items.Add("1 hour");
             // Disabled by default

            // Set up Repeat CheckBox
            cbxRepeat.CheckedChanged += (s, e) =>
            {
                // Enable/disable day checkboxes based on Repeat CheckBox
                bool isRepeatEnabled = cbxRepeat.Checked;
                cbxMon.Enabled = isRepeatEnabled;
                cbxTue.Enabled = isRepeatEnabled;
                cbxWed.Enabled = isRepeatEnabled;
                cbxThu.Enabled = isRepeatEnabled;
                cbxFri.Enabled = isRepeatEnabled;
                cbxSat.Enabled = isRepeatEnabled;
                cbxSun.Enabled = isRepeatEnabled;
            };

            // Set up Save and Cancel buttons
            btnSave.Click += (s, e) => SaveAlarm();
            btnCancel.Click += (s, e) => this.Close();
        }
        private void SaveAlarm()
        {
            // Validate and save the alarm settings
            int hour = (int)numHour.Value;
            int minute = (int)numMinute.Value;
            string ampm = lstAMPM.SelectedItem.ToString();
            bool isRepeat = cbxRepeat.Checked;
            List<DayOfWeek> repeatDays = new List<DayOfWeek>();

            if (isRepeat)
            {
                if (cbxMon.Checked) repeatDays.Add(DayOfWeek.Monday);
                if (cbxTue.Checked) repeatDays.Add(DayOfWeek.Tuesday);
                if (cbxWed.Checked) repeatDays.Add(DayOfWeek.Wednesday);
                if (cbxThu.Checked) repeatDays.Add(DayOfWeek.Thursday);
                if (cbxFri.Checked) repeatDays.Add(DayOfWeek.Friday);
                if (cbxSat.Checked) repeatDays.Add(DayOfWeek.Saturday);
                if (cbxSun.Checked) repeatDays.Add(DayOfWeek.Sunday);
            }

            // Convert to 24-hour format
            if (ampm == "PM" && hour < 12) hour += 12;
            if (ampm == "AM" && hour == 12) hour = 0;

            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);

            // Save the alarm (you can pass this data back to the main form)
            // For example, you can use a public property or event to pass the alarm data
            AlarmData = new AlarmData
            {
                AlarmTime = alarmTime,
                RepeatDays = repeatDays,
                IsRepeat = isRepeat
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Public property to pass alarm data back to the main form
        public AlarmData AlarmData { get; private set; }
    }

    // Class to hold alarm data
    public class AlarmData
    {
        public DateTime AlarmTime { get; set; }
        public List<DayOfWeek> RepeatDays { get; set; }
        public bool IsRepeat { get; set; }
    }
}

    

