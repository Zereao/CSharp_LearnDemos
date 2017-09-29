using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基本语法
{
    class Rectangle
    {
        double length;
        double width;

        public void acceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
            //          当 WriteLine() 函数有多个参数时，输出第一个参数中的内容，
            //          而第二个参数中的内容替换掉第一个参数中对应位置的占位符一起输出。

            Console.WriteLine("A:,a:", 65, 97); //运行结果：        A:,a:
            //          如果第一个参数没有留占位符,那么第二个参数内容不输出.

            //          占位符从零开始计数,且占位符中的数字不能大于第二个参数的个数减一(要求占位符必须有可替换的值)。


            //          占位符数字与第二个参数字符位置一 一 对应
            Console.WriteLine("A:{1}，a:{0}", 65, 97);   //运行结果：     A:97,a:65
        }
    }
    class ExecuteRectangle
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            r.acceptDetails();
            r.display();
            Console.ReadLine();
            //          readline() 按enter结束
            //          readkey() 按任意非功能键结束
        }
    }
}

/**
 *      标识符必须以字母、下划线或 @ 开头，后面可以跟一系列的字母、数字（ 0 - 9 ）、下划线（ _ ）、@。
 *      标识符中的第一个字符不能是数字。
 *      标识符必须不包含任何嵌入的空格或符号，比如 ? - +! # % ^ & * ( ) [ ] { } . ; : " ' / \。
 *      标识符不能是 C# 关键字。除非它们有一个 @ 前缀。 例如，@if 是有效的标识符，但 if 不是，因为 if 是关键字。
 *      标识符必须区分大小写。大写字母和小写字母被认为是不同的字母。
 *      不能与C#的类库名称相同。
 */
