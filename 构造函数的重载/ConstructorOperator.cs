using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 构造函数的重载
{
    class ConstructorOperator
    {
        private string name;
        private int age;

        public ConstructorOperator()
        {
            Console.WriteLine("调用了无参构造函数！");
        }

        public ConstructorOperator(string name)
        {
            this.name = name;
            Console.WriteLine("调用了有一个参数的构造函数！参数为 name = {0}", this.name);
        }

        public ConstructorOperator(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("调用了有两个参数的构造函数！参数为 name = {0} ，age = {1}", this.name, this.age);
        }

        public static void Main(string[] args)
        {
            var nullOp = new ConstructorOperator();
            var oneOp = new ConstructorOperator("郭靖");
            var twoOp = new ConstructorOperator("令狐冲", 21);
        }
    }
}
