using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameLister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a location to Scan Files");
            var location = Console.ReadLine();
            Console.WriteLine("Please the directory section you want to avoid showing");
            var replaceString = Console.ReadLine();
            Console.WriteLine("Where do you want to create your file");
            var filePath = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(location) && !string.IsNullOrWhiteSpace(filePath))
            {
                var files = new DirectoryInfo(location).GetFiles("*.config", SearchOption.AllDirectories);
                var csvFile = new StringBuilder();
                foreach (var file in files)
                {
                    csvFile.AppendLine($"{file.DirectoryName.Replace(replaceString, "")} \\ {file.Name}");
                }
                File.WriteAllText(filePath +"\\91cd.txt", csvFile.ToString());
            }
            else
                Console.WriteLine("Location Missing, Application will End");

            Console.Read();
        }
    }
}
