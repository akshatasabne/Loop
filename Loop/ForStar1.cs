using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class ForStar1
    {
        static void Main(string[] args)
        {
            //int x, y;
            //for (x = 6; x>=1; x--)
            //{
            //    for (y = 1; y <= x; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i >=num; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j + " ");
                }Console.WriteLine();
            }
        }
    }
}
