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
    public partial class AlarmControl : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private DateTime alarmTime;
        private bool isAlarmEnabled = false;
        private List<DayOfWeek> repeatDays = new List<DayOfWeek>();
       
        public AlarmControl()
        {
            InitializeComponent();
        }

        private void AlarmControl_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Check every second
            timer.Tick += AlarmTimer_Tick;
            timer.Start();
        }
        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (isAlarmEnabled && DateTime.Now >= alarmTime && repeatDays.Contains(DateTime.Now.DayOfWeek))
            {
                TriggerAlarm();
            }
        }

        private void TriggerAlarm()
        {
            // Stop the alarm from triggering repeatedly
            isAlarmEnabled = false;
            chkEnableAlarm.Checked = false;

            // Notify the user (e.g., play a sound, show a message)
            MessageBox.Show("Alarm! Wake up!");
            // You can also play a sound using System.Media.SoundPlayer
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void chkEnableAlarm_CheckedChanged(object sender, EventArgs e)
        {
            isAlarmEnabled = chkEnableAlarm.Checked;
            lblAlarmNotif.Text = isAlarmEnabled ? "Alarm Enabled" : "Alarm Disabled";
        }

        private void UpdateRepeatDays()
        {
            repeatDays.Clear();
            if (cbxSun.Checked) repeatDays.Add(DayOfWeek.Sunday);
            if (cbxMon.Checked) repeatDays.Add(DayOfWeek.Monday);
            if (cbxTue.Checked) repeatDays.Add(DayOfWeek.Tuesday);
            if (cbxWed.Checked) repeatDays.Add(DayOfWeek.Wednesday);
            if (cbxThu.Checked) repeatDays.Add(DayOfWeek.Thursday);
            if (cbxFri.Checked) repeatDays.Add(DayOfWeek.Friday);
            if (cbxSat.Checked) repeatDays.Add(DayOfWeek.Saturday);
        }

        private void cbxSun_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxMon_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxTue_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxWed_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxThu_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxFri_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxSat_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void lblAlarmNotif_Click(object sender, EventArgs e)
        {

        }

        private void lblAlarmName_Click(object sender, EventArgs e)
        {

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenAlarmEditor();
        }
        private void OpenAlarmEditor()
        {
            using (alarmeditor editor = new alarmeditor())
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the alarm data from the editor
                    AlarmData alarmData = editor.AlarmData;
                    SetAlarm(alarmData.AlarmTime, alarmData.RepeatDays, alarmData.IsRepeat);
                  
                }
            }
        }
        private void SetAlarm(DateTime alarmTime,List<DayOfWeek> repeatDays,bool isReapet)
        {

        }
    }
}
