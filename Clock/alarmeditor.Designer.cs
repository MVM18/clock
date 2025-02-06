namespace Clock
{
    partial class alarmeditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTimerName = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            numMinute = new NumericUpDown();
            numHour = new NumericUpDown();
            cbxSat = new CheckBox();
            cbxFri = new CheckBox();
            cbxThu = new CheckBox();
            cbxWed = new CheckBox();
            cbxTue = new CheckBox();
            cbxMon = new CheckBox();
            cbxSun = new CheckBox();
            cbxRepeat = new CheckBox();
            lstSnooze = new ListBox();
            lstAMPM = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHour).BeginInit();
            SuspendLayout();
            // 
            // txtTimerName
            // 
            txtTimerName.Font = new Font("Segoe UI", 20F);
            txtTimerName.Location = new Point(152, 134);
            txtTimerName.Margin = new Padding(3, 2, 3, 2);
            txtTimerName.Name = "txtTimerName";
            txtTimerName.Size = new Size(110, 43);
            txtTimerName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(277, 34);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 22);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 20F);
            btnCancel.Location = new Point(222, 306);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 47);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(78, 306);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 47);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // numMinute
            // 
            numMinute.Font = new Font("Segoe UI", 20F);
            numMinute.Location = new Point(159, 76);
            numMinute.Margin = new Padding(3, 2, 3, 2);
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(69, 43);
            numMinute.TabIndex = 9;
            // 
            // numHour
            // 
            numHour.Font = new Font("Segoe UI", 20F);
            numHour.Location = new Point(90, 76);
            numHour.Margin = new Padding(3, 2, 3, 2);
            numHour.Name = "numHour";
            numHour.Size = new Size(69, 43);
            numHour.TabIndex = 8;
            // 
            // cbxSat
            // 
            cbxSat.Appearance = Appearance.Button;
            cbxSat.AutoSize = true;
            cbxSat.Location = new Point(313, 230);
            cbxSat.Margin = new Padding(3, 2, 3, 2);
            cbxSat.Name = "cbxSat";
            cbxSat.Size = new Size(33, 25);
            cbxSat.TabIndex = 21;
            cbxSat.Text = "Sat";
            cbxSat.UseVisualStyleBackColor = true;
            // 
            // cbxFri
            // 
            cbxFri.Appearance = Appearance.Button;
            cbxFri.AutoSize = true;
            cbxFri.Location = new Point(277, 230);
            cbxFri.Margin = new Padding(3, 2, 3, 2);
            cbxFri.Name = "cbxFri";
            cbxFri.Size = new Size(30, 25);
            cbxFri.TabIndex = 20;
            cbxFri.Text = "Fri";
            cbxFri.UseVisualStyleBackColor = true;
            // 
            // cbxThu
            // 
            cbxThu.Appearance = Appearance.Button;
            cbxThu.AutoSize = true;
            cbxThu.Location = new Point(234, 230);
            cbxThu.Margin = new Padding(3, 2, 3, 2);
            cbxThu.Name = "cbxThu";
            cbxThu.Size = new Size(37, 25);
            cbxThu.TabIndex = 19;
            cbxThu.Text = "Thu";
            cbxThu.UseVisualStyleBackColor = true;
            // 
            // cbxWed
            // 
            cbxWed.Appearance = Appearance.Button;
            cbxWed.AutoSize = true;
            cbxWed.Location = new Point(186, 230);
            cbxWed.Margin = new Padding(3, 2, 3, 2);
            cbxWed.Name = "cbxWed";
            cbxWed.Size = new Size(41, 25);
            cbxWed.TabIndex = 18;
            cbxWed.Text = "Wed";
            cbxWed.UseVisualStyleBackColor = true;
            // 
            // cbxTue
            // 
            cbxTue.Appearance = Appearance.Button;
            cbxTue.AutoSize = true;
            cbxTue.Location = new Point(144, 230);
            cbxTue.Margin = new Padding(3, 2, 3, 2);
            cbxTue.Name = "cbxTue";
            cbxTue.Size = new Size(36, 25);
            cbxTue.TabIndex = 17;
            cbxTue.Text = "Tue";
            cbxTue.UseVisualStyleBackColor = true;
            // 
            // cbxMon
            // 
            cbxMon.Appearance = Appearance.Button;
            cbxMon.AutoSize = true;
            cbxMon.Location = new Point(95, 230);
            cbxMon.Margin = new Padding(3, 2, 3, 2);
            cbxMon.Name = "cbxMon";
            cbxMon.Size = new Size(42, 25);
            cbxMon.TabIndex = 16;
            cbxMon.Text = "Mon";
            cbxMon.UseVisualStyleBackColor = true;
            // 
            // cbxSun
            // 
            cbxSun.Appearance = Appearance.Button;
            cbxSun.AutoSize = true;
            cbxSun.Location = new Point(52, 230);
            cbxSun.Margin = new Padding(3, 2, 3, 2);
            cbxSun.Name = "cbxSun";
            cbxSun.Size = new Size(37, 25);
            cbxSun.TabIndex = 15;
            cbxSun.Text = "Sun";
            cbxSun.UseVisualStyleBackColor = true;
            // 
            // cbxRepeat
            // 
            cbxRepeat.AutoSize = true;
            cbxRepeat.Location = new Point(62, 200);
            cbxRepeat.Margin = new Padding(3, 2, 3, 2);
            cbxRepeat.Name = "cbxRepeat";
            cbxRepeat.Size = new Size(97, 19);
            cbxRepeat.TabIndex = 22;
            cbxRepeat.Text = "Repeat Alarm";
            cbxRepeat.UseVisualStyleBackColor = true;
            // 
            // lstSnooze
            // 
            lstSnooze.FormattingEnabled = true;
            lstSnooze.ItemHeight = 15;
            lstSnooze.Items.AddRange(new object[] { "disabled", "5 minutes", "10 minues", "20 minutes", "30 minutes", "1 hour" });
            lstSnooze.Location = new Point(113, 268);
            lstSnooze.Margin = new Padding(3, 2, 3, 2);
            lstSnooze.Name = "lstSnooze";
            lstSnooze.ScrollAlwaysVisible = true;
            lstSnooze.Size = new Size(133, 34);
            lstSnooze.TabIndex = 23;
            // 
            // lstAMPM
            // 
            lstAMPM.Font = new Font("Segoe UI", 20F);
            lstAMPM.FormattingEnabled = true;
            lstAMPM.ItemHeight = 37;
            lstAMPM.Items.AddRange(new object[] { "AM", "PM" });
            lstAMPM.Location = new Point(230, 77);
            lstAMPM.Margin = new Padding(3, 2, 3, 2);
            lstAMPM.Name = "lstAMPM";
            lstAMPM.Size = new Size(86, 41);
            lstAMPM.TabIndex = 24;
            // 
            // alarmeditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 382);
            Controls.Add(lstAMPM);
            Controls.Add(lstSnooze);
            Controls.Add(cbxRepeat);
            Controls.Add(cbxSat);
            Controls.Add(cbxFri);
            Controls.Add(cbxThu);
            Controls.Add(cbxWed);
            Controls.Add(cbxTue);
            Controls.Add(cbxMon);
            Controls.Add(cbxSun);
            Controls.Add(txtTimerName);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numMinute);
            Controls.Add(numHour);
            Margin = new Padding(3, 2, 3, 2);
            Name = "alarmeditor";
            Text = "alarmeditor";
            Load += alarmeditor_Load;
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimerName;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown numMinute;
        private NumericUpDown numHour;
        private CheckBox cbxSat;
        private CheckBox cbxFri;
        private CheckBox cbxThu;
        private CheckBox cbxWed;
        private CheckBox cbxTue;
        private CheckBox cbxMon;
        private CheckBox cbxSun;
        private CheckBox cbxRepeat;
        private ListBox lstSnooze;
        private ListBox lstAMPM;
    }
}