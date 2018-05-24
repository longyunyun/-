using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demol5
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] intArrary = new int[5];
            intArrary[0] = 0;
            intArrary[1] = 0;
            intArrary[2] = 0;

            intArrary[3] = 0;
            intArrary[4] = 0;
            for (int i = 0; i < intArrary.Length; i++)
            {
                intArrary[i] = 0;
            }
            /*
             * var str =MyName();
             * Console.WriteLine(str);
             * Console.ReadKey();
             * 
          */
            string inputString = "3,4,56,22,1, ,";
            var arrayString = inputString.Split(',');
            foreach (var item in arrayString)
            {
                Console.WriteLine(item);
            }

        }
        static string MyName(string inputStr)
        {
             return $"Hello {inputStr}"; 
        }
    } 
}
