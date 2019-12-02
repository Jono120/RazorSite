using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
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

            //var input = new ModelInput();

            //ModelOutput result = ConsumeModel.Predict(input);
        }

        class ImageData
        {
            public string ImagePath { get; set; }
            public string Label { get; set; }
        }

        class ModelInput
        {
            public byte[] Image { get; set; }
            public UInt32 LabelAsKey { get; set; }
            public string ImagePath { get; set; }
            public string Label { get; set; }
        }

        class ModelOutput
        {
            public string ImagePath { get; set; }
            public string Label { get; set; }
            public string PredictLabel { get; set; }
        }

        #region
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        // Add your Computer Vision subscription key and endpoint to your environment variables. 
        // Close/reopen your project for them to take effect.
        static string subscriptionKey = Environment.GetEnvironmentVariable("b3bdfe3d705041f88c6d4fde88c88981");
        static string endpoint = Environment.GetEnvironmentVariable("https://visionpage.cognitiveservices.azure.com/");

        internal CustomVisionTrainingClient TrainingApi { get; set; } = new CustomVisionTrainingClient()
        {
            ApiKey = "b3bdfe3d705041f88c6d4fde88c88981",
            Endpoint = "https://visionpage.cognitiveservices.azure.com/"
        };
        #endregion
    }
}

