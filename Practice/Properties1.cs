using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Student1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Show()
        {
            Console.WriteLine("Name = {0}  ,Age = {1}",this.Name,this.Age);
        }
    }
    class Student2 
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("Name = "+_name);
        }
    }
    class Student3
    {
        private int _age;
        private int _num;
        public Student3() => ++_num;
        public int Age          //read - write instance property
        {
            get => _age;
            set => _age = value;
        }
        public int Num          //read - only instance property
        {
            get => _num;
        }
        public void Show()
        {
            Console.WriteLine("Age = " + _age +" Num = "+_num);
        }

        public string Dip
        {
            get => Display();
        }

        private string Display()
        {
            return "Private Display";
        }

    }
    class Properties1
    {
        public static void Main()
        {
            Student1 s = new Student1();
            s.Name = "Ram";
            s.Age = 20;
            s.Show();
            
            Student2 s2 = new Student2();
            s2.Name = "Ram";
            s2.Show();
            
            Student3 s3 = new Student3();
            s3.Age = 20;
            s3.Show();
            s3.Age += 2;
            s3.Show();
            Console.WriteLine(s3.Dip); 
            
            Console.ReadLine();
        }
    }
}
