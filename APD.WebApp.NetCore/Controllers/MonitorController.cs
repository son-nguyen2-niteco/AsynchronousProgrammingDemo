using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APD.WebApp.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController
    {
        private readonly HttpClient _client;

        public MonitorController()
        {
            _client = new HttpClient();
        }

        [HttpGet]
        [Route("")]
        public async Task<string> Index()
        {
            Console.WriteLine($"before await: {Thread.CurrentThread.ManagedThreadId}");

            var ip = await GetIpAsync();

            Console.WriteLine($" after await: {Thread.CurrentThread.ManagedThreadId}");

            return ip;
        }

        /// <summary>
        /// Surprisingly there is NO deadlock.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Deadlock")]
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