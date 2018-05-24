using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeWay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            dt.ToString();
            DateTime birthday = Convert.ToDateTime("1999-9-7");
            TimeSpan span = dt.Subtract(birthday);
            int dayDiff = span.Days + 1;
            Console.WriteLine(dayDiff);
            Console.ReadKey();
        }
    }
}
