using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MyTest
    {
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }
    }
    public class Event2
    {
        public void TestEvent()
        {
            MyTest myTest = new MyTest();
            myTest.MyEvent += myTest_MyEvent;
            myTest.MyEvent -= myTest_MyEvent;
        }
        public void myTest_MyEvent(object sender, EventArgs e)
        {
        }

        static void Main(string[] args)
        {
            Event2 test = new Event2();
            test.TestEvent();
            Console.ReadKey();
        }
    }
    
}