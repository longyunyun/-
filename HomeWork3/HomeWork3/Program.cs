using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{/// <summary>
/// 成绩统计
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入成绩，用逗号隔开");
            string inputString = Console.ReadLine();
            var arrayString = inputString.Split(',');
          
         
          
            
                Console.WriteLine("90分-100分人数："+arrayString.Count(m => Int32.Parse(m) >= 90));
            Console.WriteLine("60分-89分人数：" + arrayString.Count(m => Int32.Parse(m) >= 60 && Int32.Parse(m)<90));
            Console.WriteLine("小于60分人数：" + arrayString.Count(m =>  Int32.Parse(m) < 60));






            Console.ReadKey();
        }
        
     
    }
  }
