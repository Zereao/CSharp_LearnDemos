using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 泛型方法
{
    class GenericMethod
    {
        static void SwapH<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }

        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            char c = 'T';
            char d = 'V';

            //             在交换之前显示值
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //            调用Swap方法
            SwapH(ref a, ref b);
            SwapH(ref c, ref d);

            // 在交换之后显示值
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadKey();
        }
    }
}
