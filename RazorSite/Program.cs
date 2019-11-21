using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RazorSiteML.Model;

namespace RazorSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        // Add input data
        var input = new ModelInput();

        // Load model and predict output of sample data
        ModelOutput result = ConsumeModel.Predict(input);

        //string trainingkey = Environment.GetEnvironmentVariable("45c714d75ff847fd8e45719009d766d6");
        //string predictionkey = Environment.GetEnvironmentVariable("");
    }
}
