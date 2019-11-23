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

        //    // Add your training & prediction key from the settings page of the portal
        //    string trainingKey = Environment.GetEnvironmentVariable("45c714d75ff847fd8e45719009d766d6");
        //    string predictionKey = Environment.GetEnvironmentVariable("b83ef8fe0107440290701e3fc97cea59");

        //    string ENDPOINT = Environment.GetEnvironmentVariable("https://australiaeast.api.cognitive.microsoft.com/");

        //    // Create a new project

        //        var project = TrainingApi.CreateProject("My New Project");

        //    // Make two tags in the new project
        //    var hemlockTag = TrainingApi.CreateTag(project.Id, "Hemlock");
        //    var japaneseCherryTag = TrainingApi.CreateTag(project.Id, "Japanese Cherry");

        //    internal CustomVisionTrainingClient TrainingApi { get; set; } = new CustomVisionTrainingClient()
        //    {
        //        ApiKey = trainingKey,
        //        Endpoint = ENDPOINT
        //    };
    }
}
