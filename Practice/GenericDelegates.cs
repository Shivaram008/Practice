using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void Numbers<T1, T2>(T1 a, T2 b);
    class GenericDelegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Sum of a and b = " + (a + b));
        }
        public void Mul(double a, double b)
        {
            Console.WriteLine("Product of a and b = " + (a * b));
        }
        public static void Main()
        {
            GenericDelegates g = new GenericDelegates();
            //Numbers<int, int> n = new Numbers<int,int>(Add);
            Numbers<int, int> n = Add;
            n(10, 20);
            
            Numbers<double, double> m=g.Mul;
            m(10, 5);
            Console.ReadKey();
        }
    }
}