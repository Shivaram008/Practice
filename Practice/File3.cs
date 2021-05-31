using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class File3
    {
        static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file3.txt";
        public static void Main()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            /*var text = "This is some text written to the textfile named Textfile using FileStream class.";
            byte[] writeArr = Encoding.UTF8.GetBytes(text);
            File.WriteAllBytes(path,writeArr);

            var s = File.ReadAllBytes(path);
            Console.WriteLine(Encoding.UTF8.GetString(s, 0, s.Length));*/

            FileStream fs = File.OpenWrite(path);
            var text = "This is some text written to the textfile named Textfile using FileStream class."+Environment.NewLine+"Hai";
            byte[] writeArr = Encoding.UTF8.GetBytes(text);
            fs.Write(writeArr, 0, text.Length);
            fs.Close();

            FileStream fr = File.OpenRead(path);
            var s = new byte[text.Length];
            int count = fr.Read(s, 0, s.Length);
            Console.WriteLine(Encoding.UTF8.GetString(s, 0, count));

        }
    }
}
