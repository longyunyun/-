using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demol3
{
    class Program
    {/// <summary>
    /// 类型转换
    ///     1.隐式转换
    ///     2.显式转换
    ///          2.1在前面加（）
    ///          2.2Convert
    ///          2.3 ToString
    ///          2.4 Parse
    ///          2.5 TryParse
    /// </summary> 
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //在要转换的前面加圆括号
            /*double testNumber = (double)3+4.0;
            string testString = "mynumber is:" +( 3 + 5) ;
            const double myNumber = 64.333;
            int Answer = (int)Math.Ceiling(myNumber);
            Answer=int.Parse("3");
            Console.WriteLine(Answer);
             Answer = Convert.ToInt32(Math.Floor(myNumber));
           //四舍五入加0.5取Floor
            Console.WriteLine();
             int number = int.Parse(inputString);*/
            Console.Write("please input number:");
            string inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int number))
            {
                Console.WriteLine(number);

            }
            else
                Console.WriteLine("输入错误");
           
           
            Console.ReadKey();
        }
    }
}
