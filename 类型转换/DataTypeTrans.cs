using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类型转换
{
    class DataTypeTrans
    {
        public void dataTypeConversion_1()
        {
            double d = 5673.74;
            int i = 0;

            i = (int)d;
            Console.WriteLine(i);
        }

        public void dataTypeConversion_2()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7654;
            bool b = false;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }

        static void Main(string[] args)
        {
            DataTypeTrans h = new DataTypeTrans();
            h.dataTypeConversion_1();
            h.dataTypeConversion_2();
            Console.ReadKey();
        }
    }
}

/*
 *      隐式类型转换 - 这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。
 *      例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
 *      
 *      显式类型转换 - 即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。
 */
