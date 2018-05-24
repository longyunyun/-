using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demol8
{/// <summary>
/// 函数演示
/// </summary>
    class Program
    {/*
        static int number3 = 4;//公共的
        static void Main(string[] args)
        {
           int number3 = 5;
            Console.WriteLine($"3+4={MyAdd(3, 4)}");
            Console.WriteLine("3+4={0}",MyAdd(3,4));
            Console.WriteLine(Program.number3);//全局变量 前面加类名 
            Console.WriteLine(number3);//局部变量
            Console.ReadKey();
        }
        static int MyAdd(int Number1,int Number2)
        {
            return Number1 + Number2+number3;
                
        }*/

        //递归
        static void Main(string[] args)
        {
            int ans = MyFun(100);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        static int MyFun(int i)
        {
            if (i<=1)
            {
                return i;
            }
            return i + MyFun(i - 1);
        }
    }
}
