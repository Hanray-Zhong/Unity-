using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 面对对象
{
    public enum Gender
    {
        男,
        女
    }

    /// <summary>
    /// 描述一个人
    /// </summary>
    public class person//这是一个类
    {
        private string name;
        private int age;
        private Gender gender;//这是三个字段



        public string Name//属性，可以保护字段被恶意篡改
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value>100||value<0)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Gender Sex
        {
            get { return gender;}
            set { gender = value; }
        }

        //以下定义一些方法（函数）
        public void Eating()
        {
            WriteLine(Name + " can eat.");
        }
        public void Sleeping()
        {
            WriteLine(Name + " can sleep.");
        }

    }
}
