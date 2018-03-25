using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WriteLine__
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 19;
            string name = "Hanray";
            string sex = "男";
            WriteLine("我的名字是{0},今年{1}岁，是一名{2}生。", name, year, sex);
            //添加变量的方法
            ReadKey();
        }
    }
}
