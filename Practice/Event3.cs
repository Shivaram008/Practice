using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice
{
	public delegate void Del1(string name);
	public class Event3
	{
		public static void Main()
        {
			Notify obj = new Notify();
			obj.d1 +=user1.user;
            obj.d1 += user2.user;
			obj.Notif("Ram");
        }
	}
	public class Notify
    {
		public event Del1 d1;
		public void Notif(string n)
        {
			if(d1!=null)
            {
				d1(n);
            }
        }
    }
	class user1
    {
		public static void user(string n)
        {
            Console.WriteLine("User 1 : {0}",n);
        }
    }
    class user2
    {
        public static void user(string n)
        {
            Console.WriteLine("User 2 : {0}", n);
        }
    }
}
