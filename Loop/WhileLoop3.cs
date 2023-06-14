using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class WhileLoop3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <=10)
            {
                int res = num * i;
                Console.WriteLine(res);
                i++;

            }
        }
    }
}
