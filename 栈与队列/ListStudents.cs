using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈与队列
{
    public class ListStudents
    {
        public static void ListMain()
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

            Heros zhangSan = new Heros();
            zhangSan.Id = "1005";
            zhangSan.Name = "张三";

            List<Heros> list = new List<Heros>();
            list.Add(yangGuo);
            list.Add(guoJing);
            list.Add(lingHuChong);



            foreach (var hero in list)
            {
                Console.WriteLine("学号：{0}，姓名：{1} ！", hero.Id, hero.Name);
            }

            Console.WriteLine("是否存在 ID = 1005,Name = 张三 的学生？ ：" + list.Contains(zhangSan));

        }
    }
}
