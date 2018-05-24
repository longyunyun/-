using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            //读入整数a
            Console.WriteLine("输入你的成绩a");
            int a = Convert.ToInt32(Console.ReadLine());
            //条件判断式
            if (a < 60)
                comparison = "不及格";
            else
            {
                if (a < 80)
                    comparison = "及格";
                else
                {
                    if (a < 90) comparison = "良好";
                    else
                        comparison = "优秀";
                }
            }
            Console.WriteLine(comparison);
            Console.ReadKey();
           
        }
    }
}
