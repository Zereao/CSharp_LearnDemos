using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 构造函数之间相互调用
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("无参构造函数");
        }

        public Program(int a)
            : this()
        {
            Console.WriteLine("有参构造函数，该构造函数调用了无参构造函数");
        }

        public Program(int a, int b)
            : this(a)
        {
            Console.WriteLine("两参构造函数， 调用了一个参数的构造函数");
        }

        public static void Main(string[] args)
        {
            Program a = new Program();
            Program b = new Program(1);
            Program c = new Program(1, 2);
        }
    }
}
