using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Files
    {
        static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file.txt";
        static string path2 = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file1.txt";
        public static void Append(string path)
        {
            using (StreamWriter sw = File.AppendText(path))         //File.CreateText() is used to create a file
            {
                Console.WriteLine("Enter text to Append and 'stop' to exit.");
                string k = Console.ReadLine();
                while(k!= "stop")
                {
                    sw.WriteLine(k);
                    k = Console.ReadLine();
                }  
            }
        }

        public static void Show(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine("Contents in the file are :");
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Main()
        {
            if(File.Exists(path))
            {
                Show(path);
                Console.WriteLine();
            }
            else
            {
                Append(path);
                Show(path);
                Console.WriteLine();
            }
            if(!File.Exists(path2))
                File.Copy(path, path2);                     //Copying files
            Console.WriteLine("Copied file contents :");
            Show(path2);
            Console.WriteLine();
            //Append(path2);
            //Show(path2);
            
            File.Delete(path2);                             //Deleting files
            try {
                Show(path2);
            }
            catch(Exception )
            {
                Console.WriteLine("File you are looking for is deleted... ");
            }
            Console.ReadKey();
            }
    }
}
