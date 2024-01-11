using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public login_page()
        {
            InitializeComponent();
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
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM users WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(login, con);
            cmd.Parameters.AddWithValue("@username", Username.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                MessageBox.Show("Welcome to your account");

                this.Hide();
                MainPage MainPage = new MainPage();
                MainPage.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username.Text = "";
                Password.Text = "";
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
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
