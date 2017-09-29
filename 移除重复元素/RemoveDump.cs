using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 移除重复元素
{
    class RemoveDump
    {
        public void removeDumpSB()
        {
            String a = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != a[i - 1])
                    sb.Append(a[i]);
            }
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
                Console.Write(" ");
            }
        }

        public void removeDumpAll()
        {
            String a = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != a[i - 1])
                {
                    bool tag = true;
                    String temp = sb.ToString();
                    for (int j = 0; j < sb.Length; j++)
                    {
                        if (a[i] == temp[j])
                        {
                            tag = false;
                        }
                    }
                    if (tag == true)
                        sb.Append(a[i]);
                }
            }
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
                Console.Write(" ");
            }
        }

        public void removeDump_IndexOf()
        {
            String a = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a.IndexOf(a[i]);
                if (!sb2.ToString().Contains(temp.ToString()))
                {
                    sb2.Append(temp);
                    sb.Append(a[temp]);
                }
            }
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
                Console.Write(" ");
            }
        }

        public void removeDump_IndexOf_2()
        {
            String a = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a.IndexOf(a[i]);
                if (!sb.ToString().Contains(a[i]))
                {
                    sb.Append(a[temp]);
                }
            }
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            RemoveDump removeDump = new RemoveDump();
            removeDump.removeDump_IndexOf_2();
            Console.ReadLine();
        }
    }
}
