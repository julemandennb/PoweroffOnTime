using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PoweroffOnTime
{
    public partial class form1 : Form
    {

        private System.Windows.Forms.Timer timer1;
        private int counter = 0;
        public bool MessageBoxIsOpen = false;

        public bool killThis = false;

        public form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timercountdown_Tick);
            timer1.Interval = 1000;

            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ShowInTaskbar = false;



        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (!this.killThis)
            {
                e.Cancel = true;

                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;

                notifyIcon.BalloonTipText = "is not close";

                notifyIcon.BalloonTipTitle = "is run";

                notifyIcon.ShowBalloonTip(1000);
            }


            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;


        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon.BalloonTipText = "I am a NotifyIcon Balloon";

            notifyIcon.BalloonTipTitle = "Welcome Message";



            notifyIcon.ShowBalloonTip(1000);
        }

        private void lukkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.killThis = true;
            this.Close();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {

            if (sender is Button)
            {
                Button button = (Button)sender;
                timer1.Stop();
                timer1.Start();

                int numToAdd = TimeToAdd(button.Text);

                if (this.radioButtonAdd.Checked)
                {
                    counter += numToAdd;
                }
                else
                {
                    counter = numToAdd;
                }


                showTime();
            }
        }

        private int TimeToAdd(string text)
        {
            int numToAdd = 1800;

            switch (text)
            {
                case "180 min":
                    numToAdd += 1800;
                    goto case "120 min";
                case "120 min":
                    numToAdd += 1800;
                    goto case "90 min";
                case "90 min":
                    numToAdd += 1800;
                    goto case "60 min";
                case "60 min":
                    numToAdd += 1800;
                    break;
                default:
                    break;
            }

            return numToAdd;
        }

        private void timercountdown_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 0)
            {
                timer1.Stop();
#if !DEBUG
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
#endif
            }
            else if (this.radioButtonAlertOn.Checked && counter <= 300 && !this.MessageBoxIsOpen)
            {
                this.MessageBoxIsOpen = true;
                DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "add 30 min", "5 min back", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    counter += 1800;
                    this.MessageBoxIsOpen = false;
                }
            }

            showTime();
        }

        private void showTime()
        {
            TimeSpan time = TimeSpan.FromSeconds(counter);
            string timestr = time.ToString("hh':'mm':'ss");

            TimeToShowOnForm.Text = timestr;
            timeToShowUser.Text = timestr;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
    }
}