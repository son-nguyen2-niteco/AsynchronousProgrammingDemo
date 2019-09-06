using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace APD.ConsoleApp.NetCore
{
    internal static class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        private static void Main()
        {
//            MainAsync().GetAwaiter().GetResult();
            MainSync();
        }

        private static async Task MainAsync()
        {
            Console.WriteLine($"before await: {Thread.CurrentThread.ManagedThreadId}");

            var ip = await GetIpAsync();

            Console.WriteLine($"My public IP: {ip}");

            Console.WriteLine($" after await: {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void MainSync()
        {
            Console.WriteLine($"before http request: {Thread.CurrentThread.ManagedThreadId}");

            var ip = GetIpAsync().Result;

            Console.WriteLine($"My public IP: {ip}");

            Console.WriteLine($" after http request: {Thread.CurrentThread.ManagedThreadId}");
        }

        private static async Task<string> GetIpAsync()
        {
            var ip = await Client.GetStringAsync("https://api.ipify.org");
            return ip;
        }
    }
}