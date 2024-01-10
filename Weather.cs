using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool
{
    public partial class Weather : UserControl
    {
        private readonly HttpClient _client = new HttpClient();
        private const string ApiKey = "49a7c57f5074bf490deec15724a40acb";
        public Weather()
        {
            InitializeComponent();
            this.Hide();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task GetWeatherData()
        {
            string city = textBox1.Text;
            string geoRequestUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit=5&appid={ApiKey}";

            HttpResponseMessage geoResponse = await _client.GetAsync(geoRequestUrl);
            geoResponse.EnsureSuccessStatusCode();
            string geoResponseBody = await geoResponse.Content.ReadAsStringAsync();

            JArray geoData = JArray.Parse(geoResponseBody);
            string lat = geoData[0]["lat"].ToString();
            string lon = geoData[0]["lon"].ToString();

            string weatherRequestUrl = $"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&units=metric&appid={ApiKey}";

            HttpResponseMessage weatherResponse = await _client.GetAsync(weatherRequestUrl);
            weatherResponse.EnsureSuccessStatusCode();
            string weatherResponseBody = await weatherResponse.Content.ReadAsStringAsync();

            JObject weatherData = JObject.Parse(weatherResponseBody);
            result1.Text = $"Temperature in {city}: {weatherData["current"]["temp"]}";
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await GetWeatherData();
            result1.Show();
        }
    }
}
