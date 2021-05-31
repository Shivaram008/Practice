using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class FuncDelegate
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Mul(int a,int b)
        {
            return a * b;
        }
        public static void Main()
        {
            Func<string, string> s = str => str.ToUpper();          //Lambda expression Delegate
            Console.WriteLine(s("hello"));

            Func<int, int, int> a = Add;
            Console.WriteLine(a(10,20));
            a -= Add;
            a += Mul;
            Console.WriteLine(a(2,4));
            
        }
        
    }
}
