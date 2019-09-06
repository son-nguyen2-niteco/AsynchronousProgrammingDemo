using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APD.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
        }

        private void synchronousWaitButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        private async void asynchronousWaitButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(TimeSpan.FromMinutes(1));
        }

        private async void getIpButton_Click(object sender, EventArgs e)
        {
            myIpLabel.Text = "...";

            var ip = await GetIpAsync();

            myIpLabel.Text = $"My public IP is: {ip}";
        }

        private void deadlockButton_Click(object sender, EventArgs e)
        {
            myIpLabel.Text = "...";

            var ip = GetIpAsync().Result;

            myIpLabel.Text = $"My public IP is: {ip}";
        }

        private async Task<string> GetIpAsync()
        {
            var ip = await _httpClient.GetStringAsync(domainTextBox.Text); //.ConfigureAwait(false);
            return ip;
        }
    }
}