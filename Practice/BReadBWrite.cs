using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BReadBWrite
    {
        static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file4.txt";
        public static void Main()
        {
            FileStream fs = File.OpenWrite(path);
            BinaryWriter bw = new BinaryWriter(fs);

            string name = "Ram";
            int age = 20;
            string address = "Nuzvid";

            bw.Write(name);
            bw.Write(age);
            bw.Write(address);

            bw.Write("This is some text written to the textfile named Textfile using BinaryStream class.");
            bw.Close();
            fs.Close();


            FileStream fs1 = File.OpenRead(path);
            BinaryReader br = new BinaryReader(fs1);
            string name1 = br.ReadString();
            int age1 = br.ReadInt32();
            string address1 = br.ReadString();
            string text = br.ReadString();

            Console.WriteLine(name1);
            Console.WriteLine(age1);
            Console.WriteLine(address1);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
