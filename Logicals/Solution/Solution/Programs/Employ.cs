using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Programs
{
    public class Employ
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadText("path_to_your_file.txt");

            // Create an employee
            Employ emp1 = new Employ { id = 12, name = "Rahul" };
            Employ emp2 = new Employ { id = 15, name = "Priya" };

            // Write employee data to file
            WriteText("filePath", emp1);
            WriteText("filePath", emp2);
        }

        static void ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');

                Employ emp = new Employ
                {
                    id = int.Parse(parts[0]),
                    name = parts[1]
                };

                Console.WriteLine($"ID: {emp.id}, Name: {emp.name}");
            }
        }

        static void WriteText(string filePath, Employ emp)
        {
            string line = $"{emp.id},{emp.name}";
            File.AppendAllText(filePath, line + Environment.NewLine);
        }
    }
}
