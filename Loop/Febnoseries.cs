using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Febnoseries
    {
        static void Main(string[] args)
        {
            int num=0, firstno=1, secondno=0;
            Console.WriteLine(num);
            for(int i=2; i < 10; i++)
            {
                secondno = num + firstno;
                Console.WriteLine(secondno);
                num = firstno;
                firstno = secondno;
            }
            Console.WriteLine(firstno);
        }
    }
}
