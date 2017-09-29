using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串翻转
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "I am a good man";
            Console.WriteLine("翻转之前：" + str);
            string[] strArray = str.Split(' ');
            Array.Reverse(strArray);
            Console.Write("翻转之后：");
            foreach (var s in strArray)
            {
                Console.Write(s + " ");
            }
        }
    }
}
