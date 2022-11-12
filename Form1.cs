namespace PoweroffOnTime
{
    public partial class form1 : Form
    {

        private System.Windows.Forms.Timer timer1;
        private int counter = 60;

        public form1()
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timercountdown_Tick);
            timer1.Interval = 1000;

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.Close();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button30min_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

            counter = 1800;

            showTime();
        }

        private void timercountdown_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 0)
                timer1.Stop();

            showTime();
        }

        private void showTime()
        {
            TimeSpan time = TimeSpan.FromSeconds(counter);
            string timestr =  time.ToString("hh':'mm':'ss");

            TimeToShowOnForm.Text = timestr;
            timeToShowUser.Text = timestr;
        }


    }
}