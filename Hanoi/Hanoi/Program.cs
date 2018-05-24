using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            Console.ReadKey();
        }
        static string Rules(int i, string A, string B, String C)
        {
            string ans = Rules(5, "A", "B", "C");

            if (i <= 1)
            {
                return A + "->" + C+"\r\n";
            }
            else
              

            //把中转座上的N-1个盘子移到目标座  把N-1个盘子拿到中转座  将第N个盘子移到目标座  
            return Rules(i - 1, A, C, B)  + Rules(1, A, B, C) + Rules(i - 1, B, A, C);
            Console.WriteLine(ans);
        }
    }
}
