using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void Del(int x, int y);
    public delegate string Str(string s);
    class DelegateEx
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Sum = "+ (a+b));
        }
        public void Mul(int a,int b)
        {
            Console.WriteLine("Product = "+(a*b));
        }
        public string Name(string name)
        {
            return "Hello " + name;
        }
        public static void Main()
        {
            DelegateEx d = new DelegateEx();
            Del de = d.Add;
            de += d.Mul;        //We can Add and remove methods to the delegates.
            de(10,20);
            
            Console.WriteLine();
            de -= d.Add;        //Removing Method
            de(5, 6);
            Str s = d.Name;
            Console.WriteLine(s("Ram")); 
            Console.ReadKey();

        }
    }
}
