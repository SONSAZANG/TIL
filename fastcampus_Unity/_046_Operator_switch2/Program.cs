using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Operator_switch2
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MOM,
            THE,
            WEB,
            THU,
            FRI,
            SAT,
        }
        static void Main(string[] args)
        {
            DAY_OF_WEEK dayOFWeek = DAY_OF_WEEK.FRI;
            string dayString = "";

            switch (dayOFWeek)
            {
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAY_OF_WEEK.MOM:
                    dayString = "월";
                    break;
                case DAY_OF_WEEK.THE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WEB:
                    dayString = "수";
                    break;
                case DAY_OF_WEEK.THU:
                    dayString = "목";
                    break;
                case DAY_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAY_OF_WEEK.SAT:
                    dayString = "토";
                    break;
            }

            Console.WriteLine("{0}요일입니다.", dayString);
        }
    }
}
