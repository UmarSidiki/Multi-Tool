using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool
{
    public partial class Calculator : UserControl
    {
        private List<double> resultsList = new List<double>();
        public Calculator()
        {
            InitializeComponent();
            this.Hide();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("History", 200);
            listView1.Scrollable = false;
            UpdateListView();
        }
        private void UpdateListView()
        {

            listView1.Items.Clear();

            foreach (var result in resultsList)
            {
                listView1.Items.Add(result.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                // Evaluate the expression and display the result
                DataTable table = new DataTable();
                var result = table.Compute(textBox.Text, "");
                textBox.Text = result.ToString();

                // Add the result to the history
                double resultValue;
                if (double.TryParse(result.ToString(), out resultValue))
                {
                    resultsList.Add(resultValue);

                    // Update the ListView
                    UpdateListView();
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during evaluation
                textBox.Text = "Error";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle the selected item in the ListView here if needed
            if (listView1.SelectedItems.Count > 0)
            {
                // Example: Display the selected item in a MessageBox
                MessageBox.Show("Selected item: " + listView1.SelectedItems[0].Text);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
