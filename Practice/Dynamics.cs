using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Dynamics
    {
        public static void addstr(dynamic s1, dynamic s2)
        {
            dynamic s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine("S1 Type = "+s1.GetType().ToString()+", S2 Type = "+s2.GetType().ToString());
            Console.WriteLine("Result Type = "+s3.GetType().ToString());
            Console.WriteLine();
        }

        static public void Main()
        {

            addstr('G', "G");
            addstr("Cat", "Dog");
            addstr("Hello",123);
            addstr(1232,"Hello");
            addstr(12, 30);
            addstr(123, 12.23);
            addstr(12.23f, 123);
        }
    }
}
