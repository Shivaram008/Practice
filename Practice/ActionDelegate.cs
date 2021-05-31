using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ActionDelegate
    {
        public static void Display(string s)
        {
            Console.WriteLine("Hello ,"+s);
        }
        public static void Show(String s)
        {
            Console.WriteLine("Show method :"+s);
        }
        public static void Main()
        {
            Action<string> a=Display;
            a += Show;
            a("Ram");
        }
    }
}
