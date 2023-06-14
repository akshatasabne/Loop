using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int fact=0, num, i;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            if(num>0 )
            {
                for( i=num-1;i>0;i--) 
                {
                    fact = fact * i;
                }
            }Console.WriteLine(fact);
        }
    }
}
