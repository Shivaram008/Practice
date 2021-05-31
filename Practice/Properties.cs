using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Student
    {
        private string _name;
        private int _id;
        public Student(string name,int id)
        {
            this._name = name;
            this._id = id;
        }
        public string Name => _name != null ?_name : "N.A";  //Read - only 
    }
    class Properties
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ram" ,101);
            Console.WriteLine(s.Name);
            Console.ReadLine();
            
        }
    }
}
