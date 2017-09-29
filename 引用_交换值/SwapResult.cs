using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 引用_交换值
{
    class SwapResult
    {
        public void swap(double a, double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {

        }
    }
}
