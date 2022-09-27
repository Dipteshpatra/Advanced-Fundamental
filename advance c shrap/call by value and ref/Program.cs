using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_value_and_ref
{
    public class Ripon
    {
        public void m1(ref int val)
        {
            val = val + 10;
            Console.WriteLine("the value of the called fun" + val);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 15;
            Ripon obj=new Ripon();
            Console.WriteLine("value before calling the fun"+val);
            obj.m1(ref val);//if we dont use ref here then it will send the previous value 15 again
            Console.WriteLine("value after calling the fun" + val);
        }
    }
}
