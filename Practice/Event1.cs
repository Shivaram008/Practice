using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate string MyDel(string str);
    class Event1
    {
        event MyDel MyEvent;

        public Event1()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            Event1 obj1 = new Event1();
            string result = obj1.MyEvent("Ram");
            Console.WriteLine(result);
        }
    }
}
