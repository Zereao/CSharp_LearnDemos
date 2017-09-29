using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 泛型类
{
    internal class MyGenericArray<T>
    {
        private T[] array;

        //        有参构造函数
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            //            声明一个整型数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //            设置值
            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i * 5);
            }
            //            获取值
            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }

            Console.WriteLine();

            //            声明一个字符数组
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //            设置值
            for (int i = 0; i < 5; i++)
            {
                charArray.SetItem(i, (char)(i + 97));
            }
            //            获取值
            for (int i = 0; i < 5; i++)
            {
                Console.Write(charArray.GetItem(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
