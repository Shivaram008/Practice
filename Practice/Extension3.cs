using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Extension3
    {
        static void Main(string[] args)
        { 
            Extension1 e = new Extension1();
            e.Show("Ram");
            e.Display("Ram");
            e.Print("Ram");
            int i = 10;
            Console.WriteLine(i.IsGreater(20)); 
        }
    }
}
