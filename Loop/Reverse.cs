using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            int res, rev=0;
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
           while(num != 0)
            {
                res = num % 10;
                rev = rev * 10 + res;
                num = num / 10;

            }
            Console.WriteLine(rev);
        }
    }
}
