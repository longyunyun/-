using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindJpg
{
    class Program
    {/// <summary>
     /// 查找JPG
     /// </summary>
     /// <param name="args"></param>
        
        public static void Main()
        {
            FileStream fs = new FileStream("result.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                string[] dirs = Directory.GetFiles(@"e:\", "*.JPG", SearchOption.AllDirectories);
                foreach (string dir in dirs)
                {
                    sw.WriteLine(dir);
                }
                sw.Close();
           
            }
            catch 
            {
            }
            Console.WriteLine("OK");
            Console.ReadKey();

        }
    }
}

