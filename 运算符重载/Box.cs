using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 运算符重载
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Hight
        {
            get { return height; }
            set { height = value; }
        }

        public double getVolume()
        {
            return length * width * height;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.height = a.height + b.height;
            box.length = a.length + b.length;
            box.width = a.width + b.width;
            return box;
        }
    }


    public class Test
    {
        public static void Main(string[] args)
        {
            Box box_1 = new Box();
            Box box_2 = new Box();
            Box box_3 = new Box();

            double volume = 0.0;

            //            box_1的属性
            box_1.Hight = 5.0;
            box_1.Length = 6.0;
            box_1.Width = 7.0;
            //            box_2的属性
            box_2.Hight = 10.0;
            box_2.Length = 12.0;
            box_2.Width = 13.0;
            //            box_1的体积
            volume = box_1.getVolume();
            Console.WriteLine("box_1的体积是：{0}", volume);
            //            box_2的体积
            volume = box_2.getVolume();
            Console.WriteLine("box_2的体积是：{0}", volume);
            //            box_3的体积
            box_3 = box_1 + box_2;
            volume = box_3.getVolume();
            Console.WriteLine("box_3的体积是：{0}", volume);
        }
    }
}
