using System;
using System.Windows.Forms;

namespace Multi_Tool
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_page login_page = new login_page();
            login_page.Show();
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weather1.Show();
            weather1.BringToFront();

            calculator1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator1.Show();
            calculator1.BringToFront();

            weather1.Hide();
        }

        private void calculator1_Load(object sender, EventArgs e)
        {

        }
    }
}
