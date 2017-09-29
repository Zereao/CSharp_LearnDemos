using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace 生产线订单算法
{
    class Program
    {
        public static string startDate = "2017/08/17";
        public static int tag = 4;

        public static void Main(string[] args)
        {
            Dictionary<string, int> moDic = new Dictionary<string, int>();
            moDic.Add("mo1", 34200);
            moDic.Add("mo2", 21600);
            moDic.Add("mo3", 14400);
            moDic.Add("mo4", 63000);

            Console.WriteLine("MO" + "    当日产能" + "    开始时间" + "    结束时间");
            new Program().MO_Planning(moDic);

            Console.WriteLine();

            List<Product> list = new Program().MO_Planning_My(moDic);
            foreach (var product in list)
            {
                Console.WriteLine(product.Mo + "    " + product.ProducePower + "    " + product.StartDate + "    " +
                                  product.EndDate);
            }
        }



        public void MO_Planning(Dictionary<string, int> dic)
        {
            MidClass midClass = new MidClass();
            midClass.Date = startDate;
            midClass.ProPwoer = 0;

            ICollection c = dic.Keys;
            foreach (string moName in c)
            {
                midClass.ProPwoer = midClass.ProPwoer + dic[moName];
                if (midClass.ProPwoer > 28800)
                {
                    while (midClass.ProPwoer > 28800)
                    {
                        Console.Write(moName + "    ");        //输出 MO
                        if (midClass.ProPwoer >= 28000)    //如果产能大于28800，则直接输出28800
                        {
                            Console.Write(28800 + "    ");
                        }
                        //                        Console.WriteLine(i+" " + midClass.Date + " " + midClass.ProPwoer);
                        midClass.ProPwoer = midClass.ProPwoer - 28800;
                        //                        if (midClass.ProPwoer < 28800)        //如果产能小于28800，则在这里输出
                        //                        {
                        //                            Console.Write(midClass.ProPwoer + "    ");
                        //                        }
                        Console.Write(midClass.Date + "    ");        //输出开始日期
                        string temp = midClass.Date;
                        int tempInt = int.Parse(temp.Substring(8));
                        switch (tag % 7)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                tempInt++;
                                tag++;
                                break;
                            case 5:
                                tempInt += 3;
                                tag += 3;
                                break;
                        }
                        temp = temp.Remove(8);
                        midClass.Date = String.Concat(temp, tempInt.ToString());
                        Console.WriteLine(midClass.Date);    //输出结束日期
                    }
                    //循环完了后输出当前MO不足28800的部分
                    Console.WriteLine(moName + "    " + midClass.ProPwoer + "    " + midClass.Date + "    " + midClass.Date);
                }
                else
                {
                    //如果不足28800则直接输出
                    Console.WriteLine(moName + "    " + midClass.ProPwoer + "    " + midClass.Date + "    " + midClass.Date);
                }

            }
        }

        //非"重载"方法
        public List<Product> MO_Planning_My(Dictionary<string, int> dic)
        {
            List<Product> list = new List<Product>();

            MidClass midClass = new MidClass();
            midClass.Date = startDate;
            midClass.ProPwoer = 0;

            ICollection c = dic.Keys;
            foreach (string moName in c)
            {
                midClass.ProPwoer = midClass.ProPwoer + dic[moName];
                if (midClass.ProPwoer > 28800)
                {
                    while (midClass.ProPwoer > 28800)
                    {
                        Product p = new Product();
                        p.Mo = moName;        //存入当前 MO
                        if (midClass.ProPwoer >= 28000)    //如果产能大于28800，则直接存入28800
                        {
                            p.ProducePower = 28800;
                        }
                        midClass.ProPwoer = midClass.ProPwoer - 28800;
                        p.StartDate = midClass.Date;        //存入开始日期
                        string temp = midClass.Date;
                        int tempInt = int.Parse(temp.Substring(8)) + 1;
                        temp = temp.Remove(8);
                        midClass.Date = String.Concat(temp, tempInt.ToString());
                        p.EndDate = midClass.Date;    //存入结束日期

                        list.Add(p);
                    }
                    //循环完了后存入当前MO不足28800的部分
                    list.Add(new Product(moName, midClass.Date, midClass.Date, midClass.ProPwoer));
                }
                else
                {
                    //如果不足28800则直接存入
                    list.Add(new Product(moName, midClass.Date, midClass.Date, midClass.ProPwoer));
                }

            }
            return list;
        }
    }
    class MidClass
    {
        private string date;
        private int proPwoer;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int ProPwoer
        {
            get { return proPwoer; }
            set { proPwoer = value; }
        }
    }
}
