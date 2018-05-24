using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demol4
{
    struct student
    {
        public string No;
        public string Name;
        public DateTime Birthday;
    }
   
    class Program
    {
        enum MyDirection
        {
            东,
            南,
            西,
            北
        }
        static void Main(string[] args)
        {
            MyDirection myDirection = MyDirection. 东;
            var key = Console.ReadKey();
            switch (key.Key)
            {
                default:
            }
            student student1 = new student();
            student1.Name = "张三";
            student1.No = "12200101";
            student1.Birthday = new DateTime(1999, 10, 1);    
            Console.ReadKey();
        }
    }
}
