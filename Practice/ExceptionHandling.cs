using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ExceptionHandling
    {
        public static void Main()
        {
            int[] a = new int[]{ 1, 2, 3, 4 };
            //Index out of range Exception
            /*try
            {
                Console.WriteLine(a[4]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index out of range {0}",e);
            }*/


            //Format Exception
            /*try
            {
                int b = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }*/


            //Invalid Operation Exception
            /*try
            {
                List<int> c = new List<int>() { 1, 2, 3, 4 };
                foreach (var i in c)
                    c.Add(i + 5);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }*/


            //Invalid Cast Exception
            /*try
            {
                object obj = 100;
                string str = (string)obj;
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }*/


            //Key Not Found Exception
            try
            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                d[1] = "One";
                d[2] = "Two";
                Console.WriteLine(d[3]);
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
