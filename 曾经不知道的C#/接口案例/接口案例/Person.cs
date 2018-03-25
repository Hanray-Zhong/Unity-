using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口案例
{
    class Person
    {
        private string name;

        public string Name
        {
            get {
                if (name == "" || name == null)
                {
                    return "未输入名字";
                }
                else return name;
            }
            set { name = value; }
        }

        public int Age
        { get; set; }//自动属性
    }
}
