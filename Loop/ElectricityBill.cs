using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class ElectricityBill
    {
        static void Main(string[] args)
        {
            double amount, unit;
            Console.WriteLine("Enter Unit");
            unit=Convert.ToDouble(Console.ReadLine());
            if(unit <=50)
            {
                amount = unit * 0.50;
                Console.WriteLine(amount);

            }
            else if(unit <=100)
            {
                amount = unit * 0.75;
                Console.WriteLine(amount);
            }
            else if(unit<=150)
            {
                amount = unit * 1.20;
                Console.WriteLine(amount);
            }
            else if(unit <=250)
            {
                amount = unit * 1.50;
                Console.WriteLine(amount);
            }
            else
            {
               
            }
        }
    }
}
