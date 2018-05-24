using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindFiles
{
    class Program
    {

        public static void Main()
        { 
            List<string> list = GetPath(@"E:\");
                foreach (string dir in list)
                {
                    Console.WriteLine(dir);
                }
            Console.ReadKey();

        }
        static List<string> list = new List<string>();//定义list变量，存放获取到的路径
        public static List<string> GetPath(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                if (f.Extension == ".jpg")
                    list.Add(f.FullName);//添加文件的路径到列表
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                GetPath(d.FullName);
                if (d.Extension == ".jpg")
                    list.Add(d.FullName);//添加文件夹的路径到列表
            }
            return list;
        }
    }
}
