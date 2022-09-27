using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_and_readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 2;

                // Boxing copies the value of i into object o.
                object o = i;

                // Change the value of i.
                i = 4;
                //int i = 123;      // a value type
                //object o = i;     // boxing
                //int j = (int)o;   // unboxing

                // The change in i doesn't affect the value stored in o.
                System.Console.WriteLine("The value-type value = {0}", i);
                System.Console.WriteLine("The object-type value = {0}", o);
            }
        }
    }
}
