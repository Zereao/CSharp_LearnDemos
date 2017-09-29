using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 方法重载
{
    internal class Program
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public float Sum(float a, float b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("program.Sum(5, 2)={0}", program.Sum(5, 2));
            Console.WriteLine("program.Sum(5, 2, 3)={0}", program.Sum(5, 2, 3));
            Console.WriteLine("program.Sum(5.24f, 2.34f)={0}", program.Sum(5.24f, 2.34f));
        }
    }
}
