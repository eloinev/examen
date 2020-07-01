using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Имена
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\annev\OneDrive\Рабочий стол\exam\Имена\name.txt";
            //string[] lines = File.ReadAllLines(filePath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach(String line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("nicolas");
            File.WriteAllLines(filePath, lines);
            Console.ReadLine();
        }
    
    }
}
