
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 学生类
{
    class Students
    {
        private String name;
        private int age;

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }


        static void Main()
        {
            Students lhc = new Students();
            Students gj = new Students();

            lhc.setName("令狐冲");
            gj.setName("郭靖");
        }
    }
}
