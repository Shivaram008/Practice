using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ExceptHan
    {
        int result;
        ExceptHan()
        {
            result = 0;
        }
        public void Div(int a, int b)
        {
            try
            {
                result = a / b;
                Console.WriteLine("Result ={0}",result);
            } 
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("Divide by zero exception :"+Environment.NewLine+"{0}",e);
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }

        public static void Main()
        {
            ExceptHan ex = new ExceptHan();
            ex.Div(10, 0);
        }

    }
}
