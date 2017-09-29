using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate T NumberCharger<T>(T n);

namespace 委托
{
    class TestDelegate
    {
        private static int num = 10;

        public static int AddNum(int p)
        {
            num = num + p;
            return num;
        }

        public static int MultNum(int q)
        {
            num = num * q;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        public static void Main(string[] args)
        {
            //            创建委托实例
            NumberCharger<int> nc1 = new NumberCharger<int>(AddNum);
            NumberCharger<int> nc2 = new NumberCharger<int>(MultNum);

            nc1(25);
            Console.WriteLine("Value of num is:" + GetNum());

            nc2(5);
            Console.WriteLine("Value of num is:" + GetNum());
        }
    }
}
