using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APD.WebApp.NetFramework.Controllers
{
    public class MonitorController : Controller
    {
        private readonly HttpClient _client;

        public MonitorController()
        {
            _client = new HttpClient();
        }

        public async Task<string> Index()
        {
            Console.WriteLine($"before await: {Thread.CurrentThread.ManagedThreadId}");

            var ip = await GetIpAsync();

            Console.WriteLine($" after await: {Thread.CurrentThread.ManagedThreadId}");

            return ip;
        }

        public string Deadlock()
        {
            return GetIpAsync().Result;
        }

        private async Task<string> GetIpAsync()
        {
            var ip = await _client.GetStringAsync("https://api.ipify.org");
            return ip;
        }
    }
}