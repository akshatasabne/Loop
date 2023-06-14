using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Forloop3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                int res = num * i;
                Console.WriteLine(i);
            }
        }
    }
}
