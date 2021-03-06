using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class PredicateDelegate
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        public static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);
        }
    }
}
