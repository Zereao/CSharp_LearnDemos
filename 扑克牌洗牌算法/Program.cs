using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 扑克牌洗牌算法
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] type = new string[] { "红桃", "黑桃", "方块", "梅花" };
            string[] num = new string[] { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] king = new string[] { "大王", "小王" };
            int tagB = 2;
            int tagA = 1;

            List<string> list = new List<string>();
            while (true)
            {
                int TypeSeed = new Random().Next(4);
                Thread.Sleep(new Random().Next(1));
                int NumSeed = new Random().Next(13);
                int KeySeed = new Random().Next(1, 100);
                Thread.Sleep(new Random().Next(1));
                if (KeySeed == new Random().Next(1, 50) && tagB == 2)
                {
                    Console.WriteLine("大王");
                    tagB--;
                }
                if (KeySeed == new Random().Next(50, 100) && tagA == 1)
                {
                    Console.WriteLine("小王");
                    tagA--;
                }
                string strTemp = String.Concat(type[TypeSeed], num[NumSeed]);
                if (!list.Contains(strTemp))
                {
                    list.Add(strTemp);
                    Console.WriteLine(strTemp);
                }
            }
        }
    }
}
