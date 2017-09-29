using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    public class Compute : ICompute
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b)
        {

            return a + b + 1;
        }

        public int Minus(int a, int b)
        {
            return a > b ? b : a;
        }

        public int[] Order(int a, int b, int c)
        {
            int[] temp = new int[3];
            Array.Sort(temp);
            Array.Reverse(temp);
            return temp;
        }
    }

    public interface ICompute
    {
        int Add(int a, int b);
        int Minus(int a, int b);
    }

    public class Program : Compute
    {
        public static void Main(string[] args)
        {
            Program h = new Program();
            Console.WriteLine(h.Add(1, 2));
            Console.WriteLine(Sum(5, 6));
            int[] a = new int[] { 4, 5, 6 };
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
