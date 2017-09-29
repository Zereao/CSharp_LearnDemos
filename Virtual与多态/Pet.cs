using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual与多态
{
    public class Pet
    {
        public string Name;

        public void PrintName()
        {
            Console.WriteLine("Pet's Name is " + Name);
        }

        public virtual void speak()
        {
            Console.WriteLine("[Virtual] Pet is speaking.");
        }
    }

    public class Dog : Pet
    {
        public new void PrintName()
        {
            Console.WriteLine("宠物的名字是：" + Name);
        }

        public override void speak()
        {
            Console.WriteLine(Name + " is speaking: " + "汪汪汪！");
        }
    }

    public class Cat : Pet
    {
        public override void speak()
        {
            Console.WriteLine(Name + " is speaking " + "喵喵喵！");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Pet dogPet = new Dog();
            Dog dog = new Dog();

            dogPet.Name = "Jack";
            dog.Name = "Tom";

            dogPet.PrintName();
            dog.PrintName();
        }
    }
}
