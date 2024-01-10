using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool
{
    public partial class login_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Muhammad Umar\\Documents\\multi_tool.mdf\";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public login_page()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
        }

        private void login_page_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup_page signup_page = new signup_page();
            signup_page.Show();
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }
    }
}
