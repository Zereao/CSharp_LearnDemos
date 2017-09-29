using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 统计字符的个数
{
    class TheCharNum
    {
        public int theSpaceNum(string a)
        {
            String temp = a.Replace(" ", "");
            return a.Length - temp.Length;
        }

        public int theNumberNum(string a)
        {
            int tag = 0;
            foreach (char t in a)
            {
                int temp = Convert.ToInt32(t);
                if (temp >= 48 && temp <= 57)
                    tag++;
            }
            return tag;
        }

        public int theCharNum(string a)
        {
            int tag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = Convert.ToInt32(a[i]);
                if ((temp >= 65 && temp <= 90) || (temp >= 97 && temp <= 122))
                    tag++;
            }
            return tag;
        }

        public int theOtherNum(string a)
        {
            return a.Length - theCharNum(a) - theNumberNum(a) - theSpaceNum(a);
        }

        static void Main(string[] args)
        {
            TheCharNum h = new TheCharNum();
            string a = Console.ReadLine();
            Console.WriteLine("空格的个数为：{0}", h.theSpaceNum(a));
            Console.WriteLine("数字的个数为：{0}", h.theNumberNum(a));
            Console.WriteLine("字母的个数为：{0}", h.theCharNum(a));
            Console.WriteLine("其他的个数为：{0}", h.theOtherNum(a));
            Console.ReadKey();
        }
    }
}
