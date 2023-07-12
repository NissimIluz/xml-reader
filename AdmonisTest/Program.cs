using System.IO;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AdmonisTest.Services;
using System.Threading.Tasks;
using AdmonisTest.Interfaces;
using AdmonisTest.Models;

namespace AdmonisTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .Build();

            host.Services?.GetService<IApp>().Run();
        }

        static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            var Configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName)
               .AddJsonFile("appsettings.json", false)
               .Build();
            services.AddSingleton<IConfigurationRoot>(Configuration);

            services.AddSingleton<IApp, App>();
            services.AddSingleton<IXMLReader, XMLReader1>();
            services.AddSingleton<IXMLReader, XMLReader2>();
           
            services.Configure<DefaultsValues>(Configuration.GetSection("DefaultsValues"));
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

        }

    }
}
