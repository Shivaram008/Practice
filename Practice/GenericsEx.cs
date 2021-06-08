using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class GenericsEx 
    {
        public static void Display<T1, T2>(Dictionary<T1, T2> d)
        {
            foreach (var i in d)
            {
                System.Console.WriteLine($"{i.Key} : {i.Value}");
            }
            System.Console.WriteLine(d.Count);
        }

        public static void Display<T1, T2>(SortedDictionary<T1, T2> d)
        {
            foreach (var i in d)
            {
                System.Console.WriteLine($"{i.Key} : {i.Value}");
            }
            System.Console.WriteLine(d.Count);
        }


        public static void Main()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "one");
            d.Add(2, "Two");
            Dictionary<int, int> b = new Dictionary<int, int>();
            b.Add(5, 7);
            b.Add(2, 4);
            b.Add(1, 2);
            SortedDictionary<string, string> c= new SortedDictionary<string, string>();
            c.Add("Hello", "Ram");
            c.Add("Hai", "Siva");
            c.Add("A", "Apple");
            c.Add("B", "Ball");

            Display<int, string>(d);
            Display<int, int>(b);
            Display<string, string>(c);
            Console.ReadKey();

            
        }
    }
}
