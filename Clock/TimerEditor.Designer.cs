namespace Clock
{
    partial class TimerEditor
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
            numHours = new NumericUpDown();
            numMinutes = new NumericUpDown();
            numSeconds = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            txtTimerName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).BeginInit();
            SuspendLayout();
            // 
            // numHours
            // 
            numHours.Font = new Font("Segoe UI", 20F);
            numHours.Location = new Point(84, 102);
            numHours.Name = "numHours";
            numHours.Size = new Size(79, 52);
            numHours.TabIndex = 0;
            // 
            // numMinutes
            // 
            numMinutes.Font = new Font("Segoe UI", 20F);
            numMinutes.Location = new Point(169, 102);
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(79, 52);
            numMinutes.TabIndex = 1;
            // 
            // numSeconds
            // 
            numSeconds.Font = new Font("Segoe UI", 20F);
            numSeconds.Location = new Point(254, 102);
            numSeconds.Name = "numSeconds";
            numSeconds.Size = new Size(79, 52);
            numSeconds.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(75, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 63);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 20F);
            btnCancel.Location = new Point(212, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 63);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(312, 39);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(68, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTimerName
            // 
            txtTimerName.Font = new Font("Segoe UI", 20F);
            txtTimerName.Location = new Point(143, 206);
            txtTimerName.Name = "txtTimerName";
            txtTimerName.Size = new Size(125, 52);
            txtTimerName.TabIndex = 7;
            // 
            // TimerEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 434);
            Controls.Add(txtTimerName);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numSeconds);
            Controls.Add(numMinutes);
            Controls.Add(numHours);
            Name = "TimerEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer";
            Load += Edit_Load;
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numHours;
        private NumericUpDown numMinutes;
        private NumericUpDown numSeconds;
       
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
        private TextBox txtTimerName;
    }
}