using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物类的继承
{
    public class Animal
    {
        private string name;
        private string animalType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public void Eat()
        {
            Console.WriteLine("动物类 Eat函数");
        }

        public void Shout()
        {
            Console.WriteLine("动物类 shout函数");
        }
    }
}
