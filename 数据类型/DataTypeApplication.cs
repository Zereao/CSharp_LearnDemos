using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数据类型
{
    class DataTypeApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(int): {0}", sizeof(int));
            Console.ReadLine();
        }
    }
}


/*
 *      内置的引用类型有：object、dynamic 和 string。
 *      Object）类型 是 C# 通用类型系统中所有数据类型的终极基类.
 *      
 *      当一个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。
 *      object obj;                         int val;           只有装过箱的数据才能拆箱
 *      obj = 100;  // 这是装箱               val = (int)obj;   // 这是拆箱      ↑
 *      
 *      dynamic <variable_name> = value;     →      dynamic d = 20;
 *                                                  ↑ 这个变量的类型检查是在运行时发生的。
 *                                                  
 *      String str = "runoob.com";
 *      string str = @"C:\Windows";         等价于         string str = "C:\\Windows";     注意转义字符 \
 *      
 *      @ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。
 *      string str = @"<script type=""text/javascript"">
            <!--
            -->
        </script>";
 *
 *      指针类型    C# 中的指针与 C 或 C++ 中的指针有相同的功能。    int* intPtr;
 */
