namespace PoweroffOnTime
{
    partial class form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            notifyIcon = new NotifyIcon(components);
            contextMenuStripnotifyIcon = new ContextMenuStrip(components);
            timeToShowUser = new ToolStripTextBox();
            toolStripMenuItemOpen = new ToolStripMenuItem();
            lukkeToolStripMenuItem = new ToolStripMenuItem();
            TimeToShowOnForm = new Label();
            button30min = new Button();
            button90min = new Button();
            button60min = new Button();
            button120min = new Button();
            button180min = new Button();
            radioButtonAdd = new RadioButton();
            radioButtonSetTime = new RadioButton();
            radioButtonAlertOff = new RadioButton();
            radioButtonAlertOn = new RadioButton();
            contextMenuStripnotifyIcon.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ContextMenuStrip = contextMenuStripnotifyIcon;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            // 
            // contextMenuStripnotifyIcon
            // 
            contextMenuStripnotifyIcon.Items.AddRange(new ToolStripItem[] { timeToShowUser, toolStripMenuItemOpen, lukkeToolStripMenuItem });
            contextMenuStripnotifyIcon.Name = "contextMenuStripnotifyIcon";
            contextMenuStripnotifyIcon.Size = new Size(161, 73);
            // 
            // timeToShowUser
            // 
            timeToShowUser.Name = "timeToShowUser";
            timeToShowUser.ReadOnly = true;
            timeToShowUser.Size = new Size(100, 23);
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.Size = new Size(160, 22);
            toolStripMenuItemOpen.Text = "Open";
            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            // 
            // lukkeToolStripMenuItem
            // 
            lukkeToolStripMenuItem.Name = "lukkeToolStripMenuItem";
            lukkeToolStripMenuItem.Size = new Size(160, 22);
            lukkeToolStripMenuItem.Text = "Lukke";
            lukkeToolStripMenuItem.Click += lukkeToolStripMenuItem_Click;
            // 
            // TimeToShowOnForm
            // 
            TimeToShowOnForm.AutoSize = true;
            TimeToShowOnForm.Font = new Font("Segoe UI", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            TimeToShowOnForm.ForeColor = Color.Black;
            TimeToShowOnForm.Location = new Point(2, 9);
            TimeToShowOnForm.Margin = new Padding(0);
            TimeToShowOnForm.Name = "TimeToShowOnForm";
            TimeToShowOnForm.Size = new Size(796, 175);
            TimeToShowOnForm.TabIndex = 1;
            TimeToShowOnForm.Text = "No Time Set";
            // 
            // button30min
            // 
            button30min.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button30min.Location = new Point(12, 187);
            button30min.Name = "button30min";
            button30min.Size = new Size(159, 46);
            button30min.TabIndex = 2;
            button30min.Tag = "";
            button30min.Text = "30 min";
            button30min.UseVisualStyleBackColor = true;
            button30min.Click += TimeButton_Click;
            // 
            // button90min
            // 
            button90min.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button90min.Location = new Point(12, 287);
            button90min.Name = "button90min";
            button90min.Size = new Size(159, 38);
            button90min.TabIndex = 3;
            button90min.Text = "90 min";
            button90min.UseVisualStyleBackColor = true;
            button90min.Click += TimeButton_Click;
            // 
            // button60min
            // 
            button60min.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button60min.Location = new Point(12, 239);
            button60min.Name = "button60min";
            button60min.Size = new Size(159, 42);
            button60min.TabIndex = 4;
            button60min.Text = "60 min";
            button60min.UseVisualStyleBackColor = true;
            button60min.Click += TimeButton_Click;
            // 
            // button120min
            // 
            button120min.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button120min.Location = new Point(12, 331);
            button120min.Name = "button120min";
            button120min.Size = new Size(159, 38);
            button120min.TabIndex = 5;
            button120min.Text = "120 min";
            button120min.UseVisualStyleBackColor = true;
            button120min.Click += TimeButton_Click;
            // 
            // button180min
            // 
            button180min.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button180min.Location = new Point(12, 375);
            button180min.Name = "button180min";
            button180min.Size = new Size(159, 38);
            button180min.TabIndex = 7;
            button180min.Text = "180 min";
            button180min.UseVisualStyleBackColor = true;
            button180min.Click += TimeButton_Click;
            // 
            // radioButtonAdd
            // 
            radioButtonAdd.AccessibleName = "radioButtonTime";
            radioButtonAdd.AutoSize = true;
            radioButtonAdd.Checked = true;
            radioButtonAdd.Location = new Point(183, 187);
            radioButtonAdd.Name = "radioButtonAdd";
            radioButtonAdd.Size = new Size(76, 19);
            radioButtonAdd.TabIndex = 8;
            radioButtonAdd.TabStop = true;
            radioButtonAdd.Text = "Add Time";
            radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonSetTime
            // 
            radioButtonSetTime.AccessibleName = "radioButtonTime";
            radioButtonSetTime.AutoSize = true;
            radioButtonSetTime.Location = new Point(265, 187);
            radioButtonSetTime.Name = "radioButtonSetTime";
            radioButtonSetTime.Size = new Size(70, 19);
            radioButtonSetTime.TabIndex = 9;
            radioButtonSetTime.Text = "Set Time";
            radioButtonSetTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlertOff
            // 
            radioButtonAlertOff.AccessibleName = "radioButtonAlert";
            radioButtonAlertOff.AutoSize = true;
            radioButtonAlertOff.Location = new Point(267, 239);
            radioButtonAlertOff.Name = "radioButtonAlertOff";
            radioButtonAlertOff.Size = new Size(68, 19);
            radioButtonAlertOff.TabIndex = 11;
            radioButtonAlertOff.Text = "Alert off";
            radioButtonAlertOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlertOn
            // 
            radioButtonAlertOn.AccessibleName = "radioButtonAlert";
            radioButtonAlertOn.AutoSize = true;
            radioButtonAlertOn.Checked = true;
            radioButtonAlertOn.Location = new Point(185, 239);
            radioButtonAlertOn.Name = "radioButtonAlertOn";
            radioButtonAlertOn.Size = new Size(67, 19);
            radioButtonAlertOn.TabIndex = 10;
            radioButtonAlertOn.TabStop = true;
            radioButtonAlertOn.Text = "Alert on";
            radioButtonAlertOn.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonAlertOff);
            Controls.Add(radioButtonAlertOn);
            Controls.Add(radioButtonSetTime);
            Controls.Add(radioButtonAdd);
            Controls.Add(button180min);
            Controls.Add(button120min);
            Controls.Add(button60min);
            Controls.Add(button90min);
            Controls.Add(button30min);
            Controls.Add(TimeToShowOnForm);
            MaximizeBox = false;
            Name = "form1";
            Text = "Form1";
            contextMenuStripnotifyIcon.ResumeLayout(false);
            contextMenuStripnotifyIcon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripnotifyIcon;
        private ToolStripTextBox timeToShowUser;
        private ToolStripMenuItem lukkeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemOpen;
        private Label TimeToShowOnForm;
        private Button button30min;
        private Button button90min;
        private Button button60min;
        private Button button120min;
        private Button button180min;
        private RadioButton radioButtonAdd;
        private RadioButton radioButtonSetTime;
        private RadioButton radioButtonAlertOff;
        private RadioButton radioButtonAlertOn;
    }
}