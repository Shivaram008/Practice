using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Nullable
    {
        static void Main()
        {
            Nullable<int> i = null;
            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine(i.GetValueOrDefault());
            }

            
        }
    }
}
