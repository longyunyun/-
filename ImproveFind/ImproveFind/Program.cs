using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveFind
{/// <summary>
/// 读取文本文件找出现次数最多的三个字
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string Lines = File.ReadAllText(@"D:\工程\news.txt", Encoding.Unicode);
            var ResultList = from p in Lines
                    group p by p into g
                    select new { g.Key, CharacterCount = g.Count() };
            foreach (var kvp in ResultList.OrderByDescending(m => m.CharacterCount).Take(3))
            {
                Console.WriteLine($"{kvp.Key} has {kvp.CharacterCount} times");
            } 
            Console.ReadKey();

        }
    }
}
