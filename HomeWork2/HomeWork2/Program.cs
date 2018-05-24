using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //判断一组数的个数最大值最小值平均数
            Console.WriteLine("请输入一些数字并用逗号隔开");
            string str;
            str = Console.ReadLine();
            string[] number = str.Split(',');
            int length = number.Count();
            int[] num = new int[length];
            Console.WriteLine("个数：" + length);
            for (int i = 0; i < length; i++)
            {
                num[i] = Convert.ToInt32(number[i]);
            }
            int max = 0;
            for (int i = length ; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num[j] >max)
                    {
                        max = num[j];
                    }
                }
            }
            Console.WriteLine("最大值：" + max);
            int min = max;
            for (int i = length ; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num[j] < min)
                    {
                        min = num[j];
                    }
                }
            }
            Console.WriteLine("最小值：" + min);
            int sum = 0;
                for (int j = 0; j < length ; j++)  
                   sum = sum + num[j];
            double average = sum/length ;
            Console.WriteLine("平均数为：" + average);
            /*
            //冒泡排序
            Console.WriteLine("请输入十个数字并用逗号隔开");
            string str;
            str = Console.ReadLine();
            string[] number = str.Split(',');
            int length = number.Count();
            int[] num = new int[length];
            bool translate = true;
            if (length!=10)
            {
                Console.WriteLine("输入不正确，请重新输入...");
                translate = false;
            }
            for (int a = 0; a < length; a++)
            {
                if (!int.TryParse(number[a], out num[a]))
                {
                    Console.WriteLine("输入不正确，请重新输入...");
                    translate = false;
                    break;
                }
                else
                {
                    num[a] = Convert.ToInt32(number[a]);
                }
            }
            int temp = 0;
            for (int i = length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num[j] < num[j + 1])
                    {
                        temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            if (translate)
            {
                Console.WriteLine();
                Console.WriteLine("冒泡排序的结果从大到小如下：");
                for (int b = 0; b < length; b++)
                {
                    Console.Write(num[b] + " ");
                }
            }*/
            string value = Console.ReadLine();
            int i = 0;
            string find = "天津";
            int count = 0;
            while (value.IndexOf(find,i)>=0) 
            {
                i = value.IndexOf(find, i) + 1;
                count++;
            } 
            Console.WriteLine("文中出现天津的个数为：" + count);
            Console.ReadKey();
        }
    }
}
