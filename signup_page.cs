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
    public partial class signup_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Muhammad Umar\\Documents\\multi_tool.mdf\";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public signup_page()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_page login_page = new login_page();
            login_page.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            string confirmPassword = Password2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && password == confirmPassword)
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Account created successfully!");


                this.Close();
                login_page login_page = new login_page();
                login_page.Show();
            }
            else
            {
                MessageBox.Show("Please check your input and try again.");
            }
        }
        private void signup_page_Load(object sender, EventArgs e)
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
