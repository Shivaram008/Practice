using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ActionDelegate
    {
        public  void Display(string s)
        {
            Console.WriteLine("Hello ,"+s);
        }
        public  void Show(String s)
        {
            Console.WriteLine("Show method :"+s);
        }
        public static void Main()
        {
            ActionDelegate z = new ActionDelegate();
            Action<string> a=z.Display;
            a += z.Show;
            a("Ram");

        }
    }
}
