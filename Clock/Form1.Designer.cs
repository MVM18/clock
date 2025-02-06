namespace Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuClock = new ToolStripMenuItem();
            menuTimer = new ToolStripMenuItem();
            menuAlarm = new ToolStripMenuItem();
            menuStopwatch = new ToolStripMenuItem();
            btnAdd = new Button();
            panelContainer = new Panel();
            flowLayoutPanelTimers = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuClock, menuTimer, menuAlarm, menuStopwatch });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(198, 653);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuClock
            // 
            menuClock.Name = "menuClock";
            menuClock.Size = new Size(185, 50);
            menuClock.Text = "Clock";
            menuClock.Click += menuClock_Click;
            // 
            // menuTimer
            // 
            menuTimer.Name = "menuTimer";
            menuTimer.Size = new Size(185, 50);
            menuTimer.Text = "Timer";
            menuTimer.Click += menuTimer_Click;
            // 
            // menuAlarm
            // 
            menuAlarm.Name = "menuAlarm";
            menuAlarm.Size = new Size(185, 50);
            menuAlarm.Text = "Alarm";
            menuAlarm.Click += menuAlarm_Click;
            // 
            // menuStopwatch
            // 
            menuStopwatch.Name = "menuStopwatch";
            menuStopwatch.Size = new Size(185, 50);
            menuStopwatch.Text = "Stopwatch";
            menuStopwatch.Click += menuStopwatch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(927, 599);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(43, 42);
            btnAdd.TabIndex = 8;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.Controls.Add(flowLayoutPanelTimers);
            panelContainer.Location = new Point(212, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(760, 560);
            panelContainer.TabIndex = 9;
            // 
            // flowLayoutPanelTimers
            // 
            flowLayoutPanelTimers.AutoScroll = true;
            flowLayoutPanelTimers.AutoSize = true;
            flowLayoutPanelTimers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelTimers.Dock = DockStyle.Fill;
            flowLayoutPanelTimers.Location = new Point(0, 0);
            flowLayoutPanelTimers.Name = "flowLayoutPanelTimers";
            flowLayoutPanelTimers.Size = new Size(760, 560);
            flowLayoutPanelTimers.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(982, 653);
            Controls.Add(panelContainer);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuClock;
        private ToolStripMenuItem menuTimer;
        private ToolStripMenuItem menuAlarm;
        private ToolStripMenuItem menuStopwatch;
        private Button btnAdd;
        private Panel panelContainer;
        private FlowLayoutPanel flowLayoutPanelTimers;
    }
}
