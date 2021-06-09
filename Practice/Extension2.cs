using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    static class AddExtension
    {
        public static void Print(this Extension1 e,String s)
        {
            Console.WriteLine("In Print Method , Hello - "+s);
        }
        public static bool IsGreater(this int i,int n)
        {
            return i > n;
        }
    }
    class Extension2
    {
        static void Main(string[] args)
        {
            Extension1 e = new Extension1();
            e.Print("Ram");
        }
    }
}
