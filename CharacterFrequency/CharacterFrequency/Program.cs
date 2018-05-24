using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFrequency
{/// <summary>
/// 统计文章中出现次数最多的三个字
/// </summary>
    class Program
    {
        static void Main(string[] args)
        { //读取文章
            string Lines = Console.ReadLine();
            //判断每个字出现次数
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (char chr in Lines)
            {
                if (result.ContainsKey(chr.ToString()))
                    result[chr.ToString()] += 1;
                else
                    result.Add(chr.ToString(), 1);
            }
            foreach (KeyValuePair<string, int> kvp in result.OrderByDescending(m => m.Value).Take(3)
)
            {
                Console.WriteLine(string.Format("[{0}]字出现了{1}次", kvp.Key, kvp.Value));
            }
            Console.ReadLine();
        }
    }
}
