﻿namespace Clock
{
    partial class ClockControl
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
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 50F);
            lblTime.Location = new Point(190, 200);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(353, 112);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // ClockControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTime);
            Name = "ClockControl";
            Size = new Size(760, 560);
            Load += ClockControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
    }
}
