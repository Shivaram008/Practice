using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class File2
    {
        static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file3.txt";
        public static void Main()
        {
            CultureInfo cs = new CultureInfo("en-US");   
            File.CreateText(path);

            FileAttributes a = File.GetAttributes(path);
            DateTime d = File.GetCreationTime(path);
            DateTime d1 = File.GetCreationTimeUtc(path);
            DateTime l1 = File.GetLastAccessTime(path);
            Console.WriteLine(d.ToString(cs));
            Console.WriteLine(d1.ToString(cs));
            Console.WriteLine(l1.ToString(cs));
            Console.WriteLine(File.GetLastAccessTimeUtc(path).ToString(cs)); 
        }
    }
}
