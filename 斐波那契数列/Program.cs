using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 斐波那契数列
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num_1 = 1;
            int num_2 = 1;
            for (int i = 3; i <= 30; i++)
            {
                int temp = num_2;
                num_2 = num_1 + num_2;
                num_1 = temp;
                Console.WriteLine(i + " " + num_2);
            }

            Console.WriteLine("第30个数为：" + num_2);
        }
    }
}
