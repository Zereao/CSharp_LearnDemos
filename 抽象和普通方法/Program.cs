using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象和普通方法
{
    public abstract class A
    {
        public abstract void func_1();

        public void func_2()
        {
            Console.WriteLine("类A的普通方法");
        }
    }

    public class B : A
    {
        public override void func_1()
        {
            Console.WriteLine("实现类A的func_1");
        }

        public new void func_2()
        {
            Console.WriteLine("重写类A的func_2");
        }
    }
}
