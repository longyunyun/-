using System;
using System.Collections.Generic;

namespace HoneWork7
{/// <summary>
/// 找质数
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();
            lst.Add(2);
            int length = 10000;
            for (int i = 3; i < length; i++)
            {
                bool fact = true;
                for (int j = 0; j < lst.Count; j++)
                {
                    if (i % lst[j] == 0)
                    {
                        fact = false;
                        break;
                    }
                }
                if (fact)
                {
                    lst.Add(i);
                }
            }
            foreach (var m in lst)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();
        }

    }
}

