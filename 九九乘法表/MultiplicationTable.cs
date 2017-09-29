using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 九九乘法表
{
    class MultiplicationTable
    {
        public void multiplicationTable_normal()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} x {1} = {2}  ", i, j, i * j);
                }
                Console.WriteLine();
            }
        }

        public void multiplicationTable_reverse()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} x {1} = {2}  ", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MultiplicationTable h = new MultiplicationTable();
            h.multiplicationTable_normal();
            Console.WriteLine();
            h.multiplicationTable_reverse();
        }
    }
}
