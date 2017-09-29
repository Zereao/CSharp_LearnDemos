using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 闰年数
{
    class LeapYear
    {
        public bool isLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            LeapYear h = new LeapYear();
            int temp = 0;
            for (int i = 2000; i <= 5000; i++)
            {
                if (h.isLeapYear(i))
                    temp++;
            }
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
