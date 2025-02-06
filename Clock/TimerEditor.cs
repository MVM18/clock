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
    public partial class TimerEditor : Form
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public string TimerName { get; private set; }
        public bool IsDeleted { get; private set; } = false; // Flag to check if delete was pressed

        public TimerEditor(int hours = 0, int minutes = 1, int seconds = 0, string name = "New Timer")
        {
            InitializeComponent();
            numHours.Value = hours;
            numMinutes.Value = minutes;
            numSeconds.Value = seconds;
            txtTimerName.Text = name;
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save values and close the form
            Hours = (int)numHours.Value;
            Minutes = (int)numMinutes.Value;
            Seconds = (int)numSeconds.Value;
            TimerName = txtTimerName.Text;

            this.DialogResult = DialogResult.OK; // Return OK to parent form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Return Cancel
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Set delete flag and return Delete as result
            IsDeleted = true;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
