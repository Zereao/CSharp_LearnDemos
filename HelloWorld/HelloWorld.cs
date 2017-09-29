using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    //声明类
    class HelloWorld
    {
        //定义Main方法
        static void Main(string[] args)
        {
            //WriteLine 是一个定义在 System 命名空间中的 Console 类的一个方法。
            //该语句会在屏幕上显示消息 "Hello, World!"。
            Console.WriteLine("Hello World !");
            //最后一行 Console.ReadKey(); 是针对 VS.NET 用户的。
            //这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。
            Console.ReadKey();
        }
    }
}
/*
    · C# 是大小写敏感的。
    · 所有的语句和表达式必须以分号（;）结尾。
    · 程序的执行从 Main 方法开始。
    · 与 Java 不同的是，文件名可以不同于类的名称。
 */