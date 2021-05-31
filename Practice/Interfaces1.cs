using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    interface IStudentName
    {
        //Interface members are by default abstract and public
        void Name(string s);
    }
    interface IStudentInfo
    {
        //interfaces can not contains any fields and constructors
        void Address(string s);
    }
    class A
    {
       
        public void MyMethod()
        {
            Console.WriteLine("Some method in A Class ");
        }
    }
    class Interfaces1 : A,IStudentName,IStudentInfo
    {
        public void Name(string n)
        {
            Console.WriteLine("Name = "+n);
        }
        public void Address(String a)
        {
            Console.WriteLine("Address = "+a);
        }

        public static void Main()
        {
            Interfaces1 i = new Interfaces1();
            i.Name("Ram");
            i.Address("Nuzvid");
            i.MyMethod();
            Console.ReadKey();
        }
    }
}
