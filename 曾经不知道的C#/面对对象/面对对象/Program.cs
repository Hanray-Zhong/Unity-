using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 面对对象
{
    class Program
    {
        static void Main(string[] args)
        {
            person Me = new person();     //将类实例化为一个对象
            Me.Age = 18;
            Me.Name = "Hanray";
            Me.Sex = Gender.男;

            WriteLine("用户名字：" + Me.Name);
            WriteLine("用户年龄：" + Me.Age);
            WriteLine("用户性别：" + Me.Sex);

            Me.Eating();
            Me.Sleeping();

            ReadKey();
        }
    }
}
