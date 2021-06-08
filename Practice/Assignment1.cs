using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Ramforeach1 
    {
        static List<int> list;
        public static int index = -1;
        public Ramforeach1(List<int> l)
        {
            list = l;
        }
        
        public static Ramforeach1 GetEnumerator()
        {
            return (Ramforeach1)(IEnumerator)list.GetEnumerator();
        }
        public bool MoveNext()
        {
            if (index < Ramforeach1.list.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Current
        {
            get { return list[index]; }
        }

        public void Show()
        {
           /* IEnumerator ie = Ramforeach1.GetEnumerator();
            
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current.ToString());
            }*/
        }
    }
    class Assignment1
    {
        
        public static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            Ramforeach1 r1=new Ramforeach1(a);
            r1.Show();

        }
    }
}
