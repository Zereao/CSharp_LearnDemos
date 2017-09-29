using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈与队列
{
    internal class Heros
    {
        private string name;
        private string id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public static void Main(string[] args)
        {
            Heros lingHuChong = new Heros();
            lingHuChong.Id = "1001";
            lingHuChong.Name = "令狐冲";

            Heros guoJing = new Heros();
            guoJing.Id = "1002";
            guoJing.Name = "郭靖";

            Heros yangGuo = new Heros();
            yangGuo.Id = "1003";
            yangGuo.Name = "杨过";

            Stack<Heros> s = new Stack<Heros>();
            s.Push(yangGuo);
            s.Push(guoJing);
            s.Push(lingHuChong);

            Console.WriteLine("Stack：");

            foreach (var hero in s)
            {
                Console.WriteLine("学号：{0}，姓名：{1} ！", hero.Id, hero.Name);
            }

            Console.WriteLine("顶部元素：学号：{0}，姓名：{1} ！", s.Peek().Id, s.Peek().Name);

            while (s.Count > 0)
            {
                var hero = s.Pop();
                Console.WriteLine("学号：{0}，姓名：{1} ！", hero.Id, hero.Name);
                Console.WriteLine(s.Count);
            }


            Console.WriteLine("Queue：");
            QueueHeros.QueueMain();

            Console.WriteLine("Lsit：");
            ListStudents.ListMain();
        }
    }
}
