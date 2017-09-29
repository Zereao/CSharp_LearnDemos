using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈与队列
{
    public class QueueHeros
    {
        public static void QueueMain()
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

            Queue<Heros> s = new Queue<Heros>();
            s.Enqueue(yangGuo);
            s.Enqueue(guoJing);
            s.Enqueue(lingHuChong);

            foreach (var hero in s)
            {
                Console.WriteLine("学号：{0}，姓名：{1} ！", hero.Id, hero.Name);
            }

            Console.WriteLine("顶部元素：学号：{0}，姓名：{1} ！", s.Peek().Id, s.Peek().Name);

            while (s.Count > 0)
            {
                var hero = s.Dequeue();
                Console.WriteLine("学号：{0}，姓名：{1} ！", hero.Id, hero.Name);
                Console.WriteLine(s.Count);
            }

        }
    }
}
