using System.Runtime.InteropServices;
using System.Text;

namespace OpLearn
{
    public partial class Form1 : Form
    {

        public int timer = 0;
        public int targetTime = 1;

        public bool timeSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetTimer()
        {
            timer = 0;
            int.TryParse(txtMinutes.Text, out targetTime);
            targetTime = targetTime * 60;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetTimer();

            if (targetTime > 1)
            {

                timerCountdown.Enabled = true;
                timerCountdown.Start();

            }

            else

            {
                MessageBox.Show("[+] Set Time");
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private bool CheckWindow()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();
            string title = GetWindowText(handle, Buff, nChars).ToString();

            if (Buff.ToString().Contains("Visual Studio"))
            {
                return true;
            }
            return false;
        }


        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Started";
            if (timer < targetTime && CheckWindow() == true)
            {

                lblTimer.Text = (timer + 1).ToString();
                timer += 1;


            }

            else if (timer < targetTime && CheckWindow() == false)
            {

            }

            else
            {
                timerCountdown.Stop();
                lblStatus.Text = "Stopped";
                lblTimer.Text = "Target Reached ";
                MessageBox.Show("Target Reached");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}