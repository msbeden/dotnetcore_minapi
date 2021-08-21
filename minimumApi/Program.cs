using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace minimumApi
{
    public class Program
    {
        //URL Eklemelerinin yapilmasi
        private static IEnumerable<string> GetServerIpAddresses()
        {
            string strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] ipAddresses = ipEntry.AddressList;
            IList<string> urls = ipAddresses.ToList()
                                            .Where(predicate: x => !x.IsIPv6LinkLocal && !x.IsIPv6Multicast && !x.IsIPv6SiteLocal && !x.IsIPv6Teredo)
                                            .Select(ipAddress => $"http://{ipAddress}:5000")
                                            .ToList();
            urls.Add("http://localhost:5000");
            return urls;
        }

        public static void Main(string[] args)
        {
            //URL Eklemelerinin yapilmasi
            string[] urls = GetServerIpAddresses().ToArray();
            CreateHostBuilder(urls, args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] urls, string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //URL Eklemelerinin yapilmasi
                    webBuilder.UseUrls(urls);
                    webBuilder.UseStartup<Startup>();
                });
    }
}
