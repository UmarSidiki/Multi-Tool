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
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
