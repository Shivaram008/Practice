using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LambdaStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class LinqLambda
    {
        delegate bool IsTeenAger(LambdaStudent stud);
        static void Main(string[] args)
        {
            List<LambdaStudent> l1 = new List<LambdaStudent>() { 
                        new LambdaStudent() {Age=23, Name="Ram", Id=101 },
                        new LambdaStudent() {Age=22, Name="Siva", Id=208},
                        new LambdaStudent() {Age=18, Name="Prasad", Id=120},
            };
            var l2 = from s in l1 where s.Age > 20 orderby s.Age select s;
            foreach(var i in l2)
            {
                Console.WriteLine(i.Name+" "+i.Age+" "+i.Id);
            }
            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
            foreach(var i in l1)
            {
                Console.WriteLine(isTeenAger(i)+" "+i.Age);
            }
        }
    }

}
