using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 学生类的封装
{
    internal class Students
    {
        private string sthId;
        private string stuName;
        protected int age;
        private string sex;
        protected string address;
        private string idNum;

        public string SthId
        {
            get { return sthId; }
            set { sthId = value; }
        }

        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string IdNum
        {
            get { return idNum; }
            set { idNum = value; }
        }

        public static void Main(string[] args)
        {
            Students h = new Students();
        }
    }
}
