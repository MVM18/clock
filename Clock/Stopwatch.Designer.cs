namespace Clock
{
    partial class StopwatchControl
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
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            btnStart = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 50F);
            lblTime.Location = new Point(141, 188);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(506, 112);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00:00.000";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 20F);
            btnStart.Location = new Point(258, 343);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 54);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start ";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 20F);
            btnReset.Location = new Point(441, 343);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 54);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // StopwatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Name = "StopwatchControl";
            Size = new Size(760, 560);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Button btnStart;
        private Button btnReset;
    }
}
