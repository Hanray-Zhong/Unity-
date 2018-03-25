using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 堆栈关系
{
    public class Person
    {
        public enum Gender
        {
            男,
            女,
        }

        private string Name;
        private int Age;
        private Gender gender;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public Gender sex
        {
            get { return gender;}
            set { gender = value; }
        }

        ///
        /// 创建一个person对象
        ///
        public Person()
        {

        }

        public Person(string name, int age, Gender sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public void Introduce()
        {
            WriteLine("我的名字是{0},我{1}岁了，我是{2}生", name, age, sex);
        }

    }
}
