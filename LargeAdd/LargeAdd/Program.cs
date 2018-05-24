using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeAdd
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string x = "12453254955464727307";
            string y = "9767427427348835656";
            Console.WriteLine(Add(x, y));
        }
       static string Add(string x, string y)
        {
            string ans = "";
            //对齐位数
            while (x.Length < y.Length)
                x = "0" + x;
            while (x.Length > y.Length)
                y = "0" + y;
            //是否进位
            bool flag = false;
            for (int i = x.Length-1; i>=0 ; i--)
            {
                int tem = (x[i] - '0') + (y[i] - '0');
                if (flag)
                {
                    tem++;
                    flag = false;
                }
                if (tem>9)
                {
                    flag = true;
                    tem = tem - 10;
                }
                ans = tem.ToString()+ans;
            }
            if (flag)
            {
                ans = "1" + ans;
            }return ans;
        }
    }
}
