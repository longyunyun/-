using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    /// <summary>
    /// draw a triangle
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.WriteLine("******");
            Console.WriteLine("*******");
            Console.WriteLine("********");
            string strInput;

            strInput=Console.ReadLine();
            Console.Write("your input:");
            Console.Write(strInput);
            Console.Write("your {1} input:{0}", strInput, "hello");
            Console.Write($"your{strInput} input:{3 + 2}");
            Console.Write("your " + (3 + 2).ToString() + "input" + "hello");
            Console.ReadKey();

        }
    }
}
