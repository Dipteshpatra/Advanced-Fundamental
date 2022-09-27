using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covert_and_to_strING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string str1 = Convert.ToString(str);
            // Output ==> it will return 'null'
            string str2 = str.ToString();
            // Output ==> it will throw an Null reference exception

        }
    }
}
