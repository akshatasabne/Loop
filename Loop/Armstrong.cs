using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int a, b=0;
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num !> 0) 
            {
                 a = num % 10;
                 b = b + a;
                 num=num /10;
            }
            Console.WriteLine(b);
        }
    }
}
