using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            IEnumerator<int> ie = a.GetEnumerator();
            //RamForEach(ie);
        }
        //static void RamForEach()
    }
}
