using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class PrimeNo
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            for (int i = 1; i <= num; i++)
            { 
                if (num % i == 0)
                {
                    count++;
                }
             }
        if (count == 0)
            {
                Console.WriteLine("It is a prime number");
            }

            else
            {
                Console.WriteLine("It is not a Prime no");
            }

        }
    }
}