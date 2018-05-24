using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyInYear
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int i = 0;
            Console.WriteLine("Input  twelve lines. Each line will contain the closing balance of his bank account for a particular month.");
            do
            {
                decimal input = Convert.ToDecimal(Console.ReadLine());
                sum = sum + input;
                i = i + 1;
            } while (i<12);
           
           
            decimal average =sum/12;
            Console.WriteLine("$"+average);
        }
    }
}
