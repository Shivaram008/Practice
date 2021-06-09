using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Extension1
    {
        public void Display(string s)
        {
            Console.WriteLine("Hello ," + s);
        }
        public void Show(String s)
        {
            Console.WriteLine("Show method :" + s);
        }
        public static void Main()
        {
            Extension1 z = new Extension1();
            z.Display("Siva");
            z.Show("Prasad");
        }
    }
}
