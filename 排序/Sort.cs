using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    class Sort
    {
        public int[] minToMaxSort(ArrayList b)
        {
            Object[] c = b.ToArray();
            int[] a = new int[c.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(c[i]);
            }
            int[] temp = a;
            Array.Sort(temp);
            return temp;
        }
        static void Main(string[] args)
        {
            Sort h = new Sort();
            string str = Console.ReadLine().Trim();
            string[] temp = str.Split(',');
            int[] a = new int[temp.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(temp[i]);
            }
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
            for (int i = a.Length - 1; i >= 0; i--)
                Console.Write("{0} ", a[i]);
            Console.ReadKey();
        }
    }
}
