using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Multi_Tool
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            time1.Show();
            time1.BringToFront();

            weather1.Hide();
            calculator1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_page login_page = new login_page();
            login_page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weather1.Show();
            weather1.BringToFront();

            calculator1.Hide();
            time1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator1.Show();
            calculator1.BringToFront();

            weather1.Hide();
            time1.Hide();
        }

        private void calculator1_Load(object sender, EventArgs e)
        {

        }

        private void time1_Load(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Close all threads before closing the application
                foreach (ProcessThread thread in Process.GetCurrentProcess().Threads)
                {
                    thread.Dispose();
                }

                // Terminate the application
                Environment.Exit(0);
            }
        }
    }
}
