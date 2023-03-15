// See https://aka.ms/new-console-template for more information
using System.Text.Json;

namespace Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];

            FileInfo fileInfo = new(path);
            using StreamReader streamReader = new(fileInfo.OpenRead());

            List<string> lines = new();
            string fileLine;
            while((fileLine =streamReader.ReadLine()) !=null)
            {
                lines.Add(fileLine);

                string[] studentValues = fileLine.Split(',');
                Student student = new()
                {
                   FirstName = studentValues[0],
                   LastName = studentValues[1]
                }
            }
            foreach(string line in lines) 
            { 
                Console.WriteLine(line);
            }
        }
    }
}