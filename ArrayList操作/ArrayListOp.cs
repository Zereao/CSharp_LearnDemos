using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayList操作
{
    class ArrayListOp
    {
        public static void Main(string[] args)
        {
            ArrayList id = new ArrayList();
            ArrayList name = new ArrayList();
            id.Add(1001);
            id.Add(1002);
            id.Add(1003);
            name.Add("令狐冲");
            name.Add("郭靖");
            name.Add("杨过");
            name.Add("被删除的命运");

            Console.Write("id.toString() = ");
            foreach (var i in id)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("name.toString() = ");
            foreach (var i in name)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            name.Remove("被删除的命运");
            id.Insert(1, 10010);
            Console.Write("id.toString() = ");
            foreach (var i in id)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("name.toString() = ");
            foreach (var i in name)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
