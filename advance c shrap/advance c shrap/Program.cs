using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_c_shrap
{
    class Test
    {//static and non static funcion

        public void display1()
        {

            Console.WriteLine("Non static method");
        }
        public static void display2()
        {

            Console.WriteLine("Static method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.display1();
            Test.display2();// in static member function  we can cll it by class.member function name we dont have to creat a object
        }
    }
}
