using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //绝对必须用英文 必须有含义 字母数字下划线
             double dblNumber1;
             //过时了
             int intCountOfStudents;
             int CountOfStudents;
             //目前就用这个
             int countOfStudents;
             string NameOfStudents;
             string MyWords;
             //\r\n回车换行  \"双引号  \'单引号  \\一个\ 
             var i = 3;
             i++;
             i = i + 1;
             i += 1;
             Console.WriteLine("你是谁？");
             Console.ReadLine();
             MyWords = "c:\\windows\\test.txt";
             Console.WriteLine(MyWords);

             //define a string   
             string inputString;
             inputString = Console.ReadLine();
             //output a line of string to monitor
             Console.WriteLine(inputString);

             inputString = "first";
             Console.WriteLine(inputString);
             inputString = "second";
             Console.WriteLine(inputString);
             int intNumber1 = 1;
             int intNumber2 = 2;
             Console.WriteLine(intNumber1 + intNumber2);
             //this is last line of every code
             //wait for user to click a key,then end the program
             Console.WriteLine("*");
             Console.WriteLine("**");
             Console.WriteLine("***");
             Console.WriteLine("****");
             Console.WriteLine("*****");
             Console.WriteLine("******");
             Console.WriteLine("*******");
             Console.WriteLine("********");
             Console.WriteLine("*********");
             Console.WriteLine("**********");
             Console.WriteLine("*\r\n**\r\n***\r\n****\r\n*****\r\n******\r\n*******\r\n********\r\n*********\r\n**********");
             Console.ReadKey();

             int myInteger;
             string myString;
             myInteger = 17;
             myString="\"myInteger\" is  ";
             Console.WriteLine("{0}{1}.", myString, myInteger);
             Console.ReadKey();*/
            /*
            int var1, var2 = 5, var3 = 6;
            var1 = var2 ++*-- var3;
            Console.WriteLine(var1);
            int i = 1;
            int answer = 0;
            do
            {
                answer = answer + i;
                i = i + 1;

            } while (i<=100);
            Console.WriteLine(answer);
            int answer = 0;
            for(int i = 0; i < 101; i++)
            {
                answer = answer + i;
            }
            Console.WriteLine(answer);
            int lines = 10;
            string chars = "*";
            for (int i = 0; i < lines; i++)//i++就是i=i+1
            {
                Console.WriteLine(chars);
                chars += "  *";//+=是chars=chars+"*"
            }
            //输出等腰梯形
            int lines = 10;
            for (int i = 0, j = 10; i < lines; i++, j--)
            {
                var block = new string(' ',j - 1); 
                var line = new string('*', i + 1);
                Console.WriteLine(block+line+line);
            }
            Console.ReadKey();
            //输出空心等腰三角形
            int lines = 15;
                var oneLine = new string(' ', lines+2);
                Console.WriteLine(oneLine + "*");
            
            for (int i = 0, j = lines; i < lines; i++, j--)
            {
                var block = new string(' ', j - 1);
                var inside = new string(' ', i + 1);

                Console.WriteLine(" "+block + "*" + inside +" "+ inside + "*");

            }
                var bottle = new string('*', 2*lines+5);
                Console.WriteLine(bottle);
            
            Console.ReadKey();
            */

            /*
            //输出等腰三角形
            int lines = 10;
            for (int i = 0, j = lines; i < lines; i++, j--)
            {
                var block = new string(' ', j - 1);
                var line = new string('*', i );
                Console.WriteLine(block + line +"*"+line);
            }
            Console.ReadKey();
            */
            /*
            //输出菱形
            int lines = 10;
            for (int i = 0, j = lines; i < lines; i++, j--)
            {
                var block = new string(' ', j );
                var line = new string('*', i);
                Console.WriteLine(block + line + "*" + line);
            }
            for (int i = 1; i < lines; i++)
            {
                var block = new string(' ', i+1);
                var star = new string('*', lines - i-1);
                Console.WriteLine(block + "*"+star + star);
            }
            Console.ReadKey();
            */
            /*
            //输出空心菱形
            int lines = 10;
            var oneLine = new string(' ', lines + 1);
            Console.WriteLine(oneLine + "*");
            for (int i = 0, j = lines; i < lines; i++, j--)
            {
                var block = new string(' ', j);
                var line = new string(' ', i);
                Console.WriteLine(block + "*" + line +line  +" "+"*");
            }
            for (int i = 1; i < lines; i++)
            {
                var block = new string(' ', i + 1);
                var line = new string(' ', lines - i - 1);
                Console.WriteLine(block + "*" + line  +" "+  line+"*");
            }
            Console.WriteLine(oneLine + "*");
            Console.ReadKey();
            
            //输出空心等腰三角形
            Console.WriteLine("请输入行数：");
            string inputString = Console.ReadLine();
            int lines = Convert.ToInt32(inputString); 
            var oneLine = new string(' ', lines-1 );
            Console.WriteLine(oneLine + "*");

            for (int i = 0, j = lines; i < lines-2; i++, j--)
            {
                var block = new string(' ', j - 2);
                var inside = new string(' ', i );

                Console.WriteLine( block + "*" + inside+" "  + inside + "*");

            }
            var bottle = new string('*', 2 * lines -1);
            Console.WriteLine(bottle);

            Console.ReadKey();
            */
            //==是等于 =是赋值
            /*//输出质数
            int number = 10000;
            int k = 0;
            bool flag = true;
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag)
                {
                   
                    if (k%5==0&&k!=0)
                    {
                        Console.WriteLine(" ");
                    }
                    k = k + 1;
                    Console.Write(i.ToString().PadLeft(10,' '));
                }
            }
            Console.ReadKey();
            
            Random number = new Random();
            int i = number.Next(1,101);
            
            Console.WriteLine("请猜一个1-100内整数");

            String input=Console.ReadLine();
            int j = Convert.ToInt32(input);
            for (bool k=true;true;)
            {
                if (i == j)
                {
                    Console.WriteLine("恭喜你，输入正确！");
                    k = false;
                    break;
                }
                else
                {
                    if (i < j)
                    {
                        Console.WriteLine("大了，请重新输入。");
                        k = true;
                    }
                    else Console.WriteLine("小了，请重新输入。");
                    k = true;
                }
                input = Console.ReadLine();
                j = Convert.ToInt32(input);
            }
             Console.ReadKey();
            
            Console.WriteLine("请输入一个1亿以内的数。");
            int number = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            bool flag = true;
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                    else if (number%i==0)
                    {
                        flag = true;
                    }  
                }
                if (flag)
                {

                    if (k % 5 == 0 && k != 0)
                    {
                        Console.WriteLine(" ");
                    }
                    k = k + 1;
                    Console.Write(i.ToString().PadLeft(10, ' '));
                }
            }
            Console.ReadKey();
            
            Console.WriteLine("请分两行输入两个整数");
           int i= Convert.ToInt32( Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k < i; k++)
            {
                if (i%k==0&&j%k==0)
                {
                    Console.WriteLine(k);
                }
            }
            Console.ReadKey();
           */
            int length = 1000;
            string output = " ";
            
            for (int i = 1; i < length; i++)
            {
                output = Convert.ToString(i);
                if (i % 3 == 0 || output.IndexOf('3') != -1)
                { 
                    Console.Write("  ".ToString().PadLeft(10, ' '));
                }
                else
                {
                    output = Convert.ToString(i);
                    Console.Write(output.ToString().PadLeft(10, ' '));
                    }
                if (i % 10 == 0)
                
                   Console.WriteLine();
            

            }
            
            Console.ReadKey();
        }  
    }
}
