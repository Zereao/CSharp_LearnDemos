using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 高分同学名字与成绩_mooc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] temp = new string[1, 2];
            string[,] students = new string[,] { { "吴松", "89" }, { "钱东宇", "90" }, { "伏晨", "98" } };
            temp[0, 0] = students[0, 0];
            temp[0, 1] = students[0, 1];
            for (int i = 0; i < students.Length / 2; i++)
            {
                int studentX = int.Parse(students[i, 1]);
                int tempX = int.Parse(temp[0, 1]);
                if (studentX >= tempX)
                    temp[0, 0] = students[i, 0];
                temp[0, 1] = students[i, 1];
            }
            Console.Write("分数最高的是{0}，分数是{1}", temp[0, 0], temp[0, 1]);
            Console.ReadKey();
        }
    }
}
