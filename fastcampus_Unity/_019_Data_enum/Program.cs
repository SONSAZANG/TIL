using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Data_enum
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            THE
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THE, (int)DAY_OF_WEEK.THE);
        }
    }
}
