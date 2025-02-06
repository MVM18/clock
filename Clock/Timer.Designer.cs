namespace Clock
{
    partial class TimerControl
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
            btnEdit = new Button();
            btnReset = new Button();
            lblTimerName = new Label();
            btnStart = new Button();
            lblTime = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.Edit;
            btnEdit.Location = new Point(247, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(43, 42);
            btnEdit.TabIndex = 6;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 15F);
            btnReset.Location = new Point(180, 144);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(91, 42);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // lblTimerName
            // 
            lblTimerName.AutoSize = true;
            lblTimerName.Font = new Font("Segoe UI", 12F);
            lblTimerName.Location = new Point(29, 22);
            lblTimerName.Name = "lblTimerName";
            lblTimerName.Size = new Size(64, 28);
            lblTimerName.TabIndex = 10;
            lblTimerName.Text = "Name";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15F);
            btnStart.Location = new Point(67, 144);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(91, 42);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 20F);
            lblTime.Location = new Point(87, 70);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(142, 46);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // TimerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTimerName);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Controls.Add(btnEdit);
            Name = "TimerControl";
            Size = new Size(311, 214);
            Load += TimerControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private Label lblTimerName;
        private Button btnReset;
        private Button btnStart;
        private Label lblTime;
    }
}
