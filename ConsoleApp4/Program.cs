using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type casting
            String s;
            int num = 299;
            s = num.ToString();
            Console.WriteLine(s);
            //Control flow statement and use of throw.
            int a = 101;
            if (a > 100)
                throw new Exception("invaild");//it will throw a arrgument that its invaild
            else
                Console.WriteLine("something");
            //switch(break)
            int dig;
            dig = Convert.ToInt32(Console.ReadLine());
            switch (dig)
            {
                case 1:
                    Console.WriteLine("sun");
                    break;//it will exit the loop and will go to next line
                case 2:
                    Console.WriteLine("mon");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
                    // loop and go to statement
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i == 7)
                            {
                                goto lastline;
                            }
                            Console.WriteLine(i);
                        }
                    lastline: //goto label
                        Console.WriteLine("Labeled statement");
                    }
                    //user defined function
                    {
                        Sum();
                    }
                    void Sum()
                    {
                        int x = 10;
                        int y = 20;
                        int sum = x + y;//(+ is addition oparator)
                        Console.WriteLine("sum will be" + sum);
                    }
                    {
                        //check and uncheck key word
                        int m = 2147483647;
                        int n = 2147483647;
                        int o = checked(m + n);
                        //int o=unchecked(m+n);(to bypass the error we use uncheck for const value)
                    }
                    //string
                    {
                        // create string
                        string str1 = "Dip";
                        string str2 = "tesh";

                        // print string
                        Console.WriteLine(str1);
                        Console.WriteLine(str2);
                        //Length 
                        int Length = str1.Length;
                        //to join two string
                        // join two strings
                        string joinedString = string.Concat(str1, str2);
                        // lower case and uper case
                        str1 = str1.ToLower();//it will make the string into lower case 
                        str2 = str2.ToUpper();//for upper case.//this are example of inbilt function
                                              //factorial num using recuirson
                        {

                            Console.WriteLine("Enter a number");

                            int number = Convert.ToInt32(Console.ReadLine());

                            long fact = GetFactorial(number);

                            Console.WriteLine("{0} factorial is {1}", number, fact);

                            Console.ReadKey();

                        }



                        private static long GetFactorial(int number)

                        {

                            if (number == 0)

                            {

                                return 1;

                            }

                            return number * GetFactorial(number - 1);
                        }
                    }
            }
        }
    }
}

