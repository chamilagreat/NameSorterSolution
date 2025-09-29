using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using NameSorter.Core;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string inputFile = config["InputFile"] ?? ErrorHandler("InputFile");
            string outputFile = config["OutputFile"] ?? ErrorHandler("OutputFile"); 

            try
            {
                IFileService fileService = new FileService();
                INameSorter sorter = new DefaultNameSorter();

                var names = fileService.ReadLines(inputFile);
                var sortedNames = sorter.Sort(names).ToList();

                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name);
                }

                fileService.WriteLines(outputFile, sortedNames);
                Console.WriteLine($"\nSorted names written to {outputFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static string ErrorHandler(string key)
        {
            Console.WriteLine($"Configuration key '{key}' is missing.");
            Environment.Exit(1);  
            return "";
        }
    }
}