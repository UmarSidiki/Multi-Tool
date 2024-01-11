using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Multi_Tool
{
    public partial class Time : UserControl
    {
        Timer timer = new Timer();
        private const string ApiKey = "49a7c57f5074bf490deec15724a40acb";
        HttpClient client = new HttpClient();
        public Time()
        {
            InitializeComponent();
            this.Hide();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await GetTime();
            label5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task GetTime()
        {
            string city = textBox1.Text;
            string geoRequestUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit=5&appid={ApiKey}";

            HttpResponseMessage geoResponse = await client.GetAsync(geoRequestUrl);
            geoResponse.EnsureSuccessStatusCode();
            string geoResponseBody = await geoResponse.Content.ReadAsStringAsync();

            JArray geoData = JArray.Parse(geoResponseBody);
            string lat = geoData[0]["lat"].ToString();
            string lon = geoData[0]["lon"].ToString();

            string Time = $"https://api.geotimezone.com/public/timezone?latitude={lat}&longitude={lon}";

            HttpResponseMessage timeres = await client.GetAsync(Time);
            timeres.EnsureSuccessStatusCode();
            string Timeresp = await timeres.Content.ReadAsStringAsync();

            JObject Timedata = JObject.Parse(Timeresp);
            label5.Text = $"Time in {city}: {Timedata["current_local_datetime"]}";
        }
    }
}
