using System;
using System.IO;
using System.Text;

namespace Practice
{
	public class TReadandTWrite
	{
		static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file5.txt";
		public static void Main()
        {
			if (File.Exists(path))
				File.Delete(path);
			using(TextWriter tw = File.CreateText(path))
            {
				tw.WriteLine("Hello world !");
				tw.WriteLine("Welcome to files concept");
            }
			using(TextReader tr = File.OpenText(path))
            {
				string s;
				while((s=tr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
			Console.ReadKey();
        }
	}
}
