using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace HashTable操作
{
    class HashTableOp
    {
        public static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
            a.Add(1001, "令狐冲");
            a.Add(1002, "郭靖");
            a.Add(1003, "杨过");

            ICollection keys = a.Keys; //获取键的集合

            Console.WriteLine("初始：");
            foreach (var i in keys)
            {
                Console.WriteLine("学号：" + i + "姓名：" + a[i]);
            }

            a.Remove(1002);
            Console.WriteLine("删除后：");
            keys = a.Keys;
            foreach (var i in keys)
            {
                Console.WriteLine("学号：" + i + "姓名：" + a[i]);
            }
        }
    }
}
