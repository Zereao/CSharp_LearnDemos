using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算最大最小平均值
{
    class Calculate
    {
        public int min(int[] a)
        {
            Array.Sort(a);
            return a[0];
        }

        public int max(int[] a)
        {
            Array.Sort(a);
            return a[a.Length - 1];
        }

        public double average(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum / a.Length;
        }

        static void Main(string[] args)
        {
            Calculate h = new Calculate();
            string str = Console.ReadLine().Trim();
            string[] temp = str.Split(',');
            int[] a = new int[temp.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(temp[i]);
            }

            Console.WriteLine("MAX = {0}", h.max(a));
            Console.WriteLine("MIN = {0}", h.min(a));
            Console.WriteLine("AVERAGE = {0}", h.average(a));
            Console.ReadKey();
        }
    }
}
