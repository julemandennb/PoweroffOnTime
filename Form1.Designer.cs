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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripnotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timeToShowUser = new System.Windows.Forms.ToolStripTextBox();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lukkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeToShowOnForm = new System.Windows.Forms.Label();
            this.button30min = new System.Windows.Forms.Button();
            this.contextMenuStripnotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripnotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStripnotifyIcon
            // 
            this.contextMenuStripnotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToShowUser,
            this.testToolStripMenuItem,
            this.lukkeToolStripMenuItem,
            this.toolStripMenuItemOpen});
            this.contextMenuStripnotifyIcon.Name = "contextMenuStripnotifyIcon";
            this.contextMenuStripnotifyIcon.Size = new System.Drawing.Size(161, 95);
            // 
            // timeToShowUser
            // 
            this.timeToShowUser.Name = "timeToShowUser";
            this.timeToShowUser.ReadOnly = true;
            this.timeToShowUser.Size = new System.Drawing.Size(100, 23);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // lukkeToolStripMenuItem
            // 
            this.lukkeToolStripMenuItem.Name = "lukkeToolStripMenuItem";
            this.lukkeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.lukkeToolStripMenuItem.Text = "Lukke";
            this.lukkeToolStripMenuItem.Click += new System.EventHandler(this.lukkeToolStripMenuItem_Click);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // TimeToShowOnForm
            // 
            this.TimeToShowOnForm.AutoSize = true;
            this.TimeToShowOnForm.Font = new System.Drawing.Font("Segoe UI", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeToShowOnForm.ForeColor = System.Drawing.Color.Black;
            this.TimeToShowOnForm.Location = new System.Drawing.Point(2, 9);
            this.TimeToShowOnForm.Margin = new System.Windows.Forms.Padding(0);
            this.TimeToShowOnForm.Name = "TimeToShowOnForm";
            this.TimeToShowOnForm.Size = new System.Drawing.Size(796, 175);
            this.TimeToShowOnForm.TabIndex = 1;
            this.TimeToShowOnForm.Text = "No Time Set";
            // 
            // button30min
            // 
            this.button30min.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button30min.Location = new System.Drawing.Point(12, 198);
            this.button30min.Name = "button30min";
            this.button30min.Size = new System.Drawing.Size(159, 72);
            this.button30min.TabIndex = 2;
            this.button30min.Text = "30 min";
            this.button30min.UseVisualStyleBackColor = true;
            this.button30min.Click += new System.EventHandler(this.button30min_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button30min);
            this.Controls.Add(this.TimeToShowOnForm);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Form1";
            this.contextMenuStripnotifyIcon.ResumeLayout(false);
            this.contextMenuStripnotifyIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripnotifyIcon;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripTextBox timeToShowUser;
        private ToolStripMenuItem lukkeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemOpen;
        private Label TimeToShowOnForm;
        private Button button30min;
    }
}