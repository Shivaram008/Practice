using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LinqMethod
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>() { "Siva", "Ram", "Prasad", "Divya", "Bhavana", "Padma" };
            var z = s.Where(k => k.Contains("d") || k.StartsWith("D"));
            foreach(var i in z)
            {
                Console.WriteLine(i);
            }

            List<int> l1 = new List<int>();
            l1.AddRange(Enumerable.Range(1, 20));
            foreach (var i in l1.Where(n => n % 2 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
