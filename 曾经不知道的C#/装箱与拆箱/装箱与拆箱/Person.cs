using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱与拆箱
{
    class Person
    {
        #region 构造方法
        private string name;
        private int age;
        private string address;
        #endregion

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Hello()
        {
            Console.WriteLine("我是{0}，我今年{1}岁，我住在{2}.", name, age, address);
        }

        /// <summary>
        /// 重写后的ToString函数
        /// </summary>
        public override string ToString()
        {
            return string.Format("我是{0}，我今年{1}岁，我住在{2}.", name, age, address);
        }
    }
}
