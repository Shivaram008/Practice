using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    
    class File1
    {
        static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file2.txt";
        public static void Main()
        {
            if(!File.Exists(path))
            {
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.WriteLine();

            File.AppendAllText(path, appendText);
            readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
