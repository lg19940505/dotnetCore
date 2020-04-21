using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace mobileApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();
            var host = new WebHostBuilder()
                 .UseKestrel()
                 .UseUrls("http://*:5000")
                 .UseContentRoot(Directory.GetCurrentDirectory())
                 .UseIISIntegration()
                 .UseStartup<Startup>()
                 .Build();

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel()
                    .UseUrls("http://*:5000")
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration().UseStartup<Startup>();
                });
    }
}
