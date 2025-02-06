namespace Clock
{
    partial class AlarmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblAlarmName = new Label();
            chkEnableAlarm = new CheckBox();
            timerClock = new System.Windows.Forms.Timer(components);
            btnEdit = new Button();
            cbxSun = new CheckBox();
            cbxMon = new CheckBox();
            cbxTue = new CheckBox();
            cbxWed = new CheckBox();
            cbxThu = new CheckBox();
            cbxFri = new CheckBox();
            cbxSat = new CheckBox();
            lblAlarmNotif = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 16F);
            lblTime.Location = new Point(55, 78);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(120, 37);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00am";
            lblTime.Click += lblTime_Click;
            // 
            // lblAlarmName
            // 
            lblAlarmName.AutoSize = true;
            lblAlarmName.Font = new Font("Segoe UI", 14F);
            lblAlarmName.Location = new Point(55, 181);
            lblAlarmName.Name = "lblAlarmName";
            lblAlarmName.Size = new Size(140, 32);
            lblAlarmName.TabIndex = 1;
            lblAlarmName.Text = "AlarmName";
            lblAlarmName.Click += lblAlarmName_Click;
            // 
            // chkEnableAlarm
            // 
            chkEnableAlarm.Appearance = Appearance.Button;
            chkEnableAlarm.BackColor = SystemColors.Control;
            chkEnableAlarm.ImageAlign = ContentAlignment.MiddleLeft;
            chkEnableAlarm.Location = new Point(328, 88);
            chkEnableAlarm.Name = "chkEnableAlarm";
            chkEnableAlarm.Size = new Size(72, 29);
            chkEnableAlarm.TabIndex = 4;
            chkEnableAlarm.Text = "On/ Off";
            chkEnableAlarm.UseVisualStyleBackColor = false;
            chkEnableAlarm.CheckedChanged += chkEnableAlarm_CheckedChanged;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.Edit;
            btnEdit.Location = new Point(379, 336);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(43, 42);
            btnEdit.TabIndex = 7;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbxSun
            // 
            cbxSun.Appearance = Appearance.Button;
            cbxSun.AutoSize = true;
            cbxSun.Location = new Point(55, 237);
            cbxSun.Name = "cbxSun";
            cbxSun.Size = new Size(43, 30);
            cbxSun.TabIndex = 8;
            cbxSun.Text = "Sun";
            cbxSun.UseVisualStyleBackColor = true;
            cbxSun.CheckedChanged += cbxSun_CheckedChanged;
            // 
            // cbxMon
            // 
            cbxMon.Appearance = Appearance.Button;
            cbxMon.AutoSize = true;
            cbxMon.Location = new Point(111, 237);
            cbxMon.Name = "cbxMon";
            cbxMon.Size = new Size(49, 30);
            cbxMon.TabIndex = 9;
            cbxMon.Text = "Mon";
            cbxMon.UseVisualStyleBackColor = true;
            cbxMon.CheckedChanged += cbxMon_CheckedChanged;
            // 
            // cbxTue
            // 
            cbxTue.Appearance = Appearance.Button;
            cbxTue.AutoSize = true;
            cbxTue.Location = new Point(175, 237);
            cbxTue.Name = "cbxTue";
            cbxTue.Size = new Size(43, 30);
            cbxTue.TabIndex = 10;
            cbxTue.Text = "Tue";
            cbxTue.UseVisualStyleBackColor = true;
            cbxTue.CheckedChanged += cbxTue_CheckedChanged;
            // 
            // cbxWed
            // 
            cbxWed.Appearance = Appearance.Button;
            cbxWed.AutoSize = true;
            cbxWed.Location = new Point(224, 237);
            cbxWed.Name = "cbxWed";
            cbxWed.Size = new Size(49, 30);
            cbxWed.TabIndex = 11;
            cbxWed.Text = "Wed";
            cbxWed.UseVisualStyleBackColor = true;
            cbxWed.CheckedChanged += cbxWed_CheckedChanged;
            // 
            // cbxThu
            // 
            cbxThu.Appearance = Appearance.Button;
            cbxThu.AutoSize = true;
            cbxThu.Location = new Point(279, 237);
            cbxThu.Name = "cbxThu";
            cbxThu.Size = new Size(43, 30);
            cbxThu.TabIndex = 12;
            cbxThu.Text = "Thu";
            cbxThu.UseVisualStyleBackColor = true;
            cbxThu.CheckedChanged += cbxThu_CheckedChanged;
            // 
            // cbxFri
            // 
            cbxFri.Appearance = Appearance.Button;
            cbxFri.AutoSize = true;
            cbxFri.Location = new Point(328, 237);
            cbxFri.Name = "cbxFri";
            cbxFri.Size = new Size(35, 30);
            cbxFri.TabIndex = 13;
            cbxFri.Text = "Fri";
            cbxFri.UseVisualStyleBackColor = true;
            cbxFri.CheckedChanged += cbxFri_CheckedChanged;
            // 
            // cbxSat
            // 
            cbxSat.Appearance = Appearance.Button;
            cbxSat.AutoSize = true;
            cbxSat.Location = new Point(379, 237);
            cbxSat.Name = "cbxSat";
            cbxSat.Size = new Size(40, 30);
            cbxSat.TabIndex = 14;
            cbxSat.Text = "Sat";
            cbxSat.UseVisualStyleBackColor = true;
            cbxSat.CheckedChanged += cbxSat_CheckedChanged;
            // 
            // lblAlarmNotif
            // 
            lblAlarmNotif.AutoSize = true;
            lblAlarmNotif.Location = new Point(64, 138);
            lblAlarmNotif.Name = "lblAlarmNotif";
            lblAlarmNotif.Size = new Size(193, 20);
            lblAlarmNotif.TabIndex = 15;
            lblAlarmNotif.Text = "Alarm will ring on hours left";
            lblAlarmNotif.Click += lblAlarmNotif_Click;
            // 
            // AlarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAlarmNotif);
            Controls.Add(cbxSat);
            Controls.Add(cbxFri);
            Controls.Add(cbxThu);
            Controls.Add(cbxWed);
            Controls.Add(cbxTue);
            Controls.Add(cbxMon);
            Controls.Add(cbxSun);
            Controls.Add(btnEdit);
            Controls.Add(chkEnableAlarm);
            Controls.Add(lblAlarmName);
            Controls.Add(lblTime);
            Name = "AlarmControl";
            Size = new Size(490, 444);
            Load += AlarmControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblAlarmName;
        private CheckBox chkEnableAlarm;
        private System.Windows.Forms.Timer timerClock;
        private Button btnEdit;
        private CheckBox cbxSun;
        private CheckBox cbxMon;
        private CheckBox cbxTue;
        private CheckBox cbxWed;
        private CheckBox cbxThu;
        private CheckBox cbxFri;
        private CheckBox cbxSat;
        private Label lblAlarmNotif;
    }
}
