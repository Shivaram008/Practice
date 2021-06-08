using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Ramforeach
    {
        public static int index=-1 ;
        static List<int> list;
        public Ramforeach(List<int> li)
        {
            Console.WriteLine("Const");
            list = li;
        }
        
        public int Current
        {
            get { return list[index]; }
        }
        
        public bool MoveNext()
        {
            if(index<Ramforeach.list.Count)
            {
                ++index;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }
   
    class Ram
    {
        public List<int> l2;
        public Ram(List<int> list)
        {
            this.l2 = list;
        }
        public Ramforeach GetEnumerator() { return new Ramforeach(l2); }
    }

    public class Assignment
    {
        
        public static void Main()
        {
            
            List<int> l1 = new List<int>() { 1, 2, 3 ,4};
            
            Ram r = new Ram(l1);
           
            try
            {
                foreach(var i in r)
                {
                    Console.WriteLine(i);
                }
            }
            catch { Console.WriteLine("Loop ended"); }
 
        }
    }
}
