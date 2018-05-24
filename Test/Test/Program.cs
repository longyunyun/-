using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //声明一个值为12345的int型变量
            int A = 12345;
            //声明一个值为123.457的double型变量
            double B = 123.457;
            //按照右对齐方式排列输出，并换行
            Console.Write("A={0,8:D}    B={1,10:F3}", A, B);
            //按照左对齐方式输出，并换行
            Console.Write("A={0,-8:D}   B={1,-10:F3}", A, B);
            //控制台打印内容
            Console.Write("按任意键结束...");
            Console.ReadLine();
            
            //声明一个名为nameStr的string型变量
            string nameStr;
            //控制台打印内容
            Console.WriteLine("请输入你的姓名：");
            //控制台读入内容
            nameStr = Console.ReadLine();
            //控制台打印内容
            Console.WriteLine("{0},欢迎您！", nameStr);
            //控制台打印内容
            Console.Write("按任意键结束...");
            Console.ReadKey();
            
            //控制台打印内容
            Console.Write("请输入字符：");
            //控制台打印读入数据
            int content = Console.Read();
            //控制台打印内容
            Console.WriteLine("用户输入的内容为：{0}", content);
            //控制台打印内容
            Console.Write("按任意键结束...");
            Console.ReadKey();
            


        }
    }
}
