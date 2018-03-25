using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe Me = new AiLuoKe("艾洛克", "我是。。。", 100, 65, 40, "hanray");
            TaiLa Me_1 = new TaiLa("泰拉", "我是。。。", 100, 65, 40, "hanray");
            LuKaSi Me_2 = new LuKaSi("卢卡斯", "我是。。。", 100, 65, 40, "hanray");
            LuoFei Me_3 = new LuoFei("洛菲", "我是。。。", 100, 65, 40, "hanray");
            Me.Hello(); //子类可以直接调用在父类中使用的函数
            Me.skill_1();
            Me.skill_2();
            Me.skill_3();
            Me_1.Hello();
            Me_1.skill_1();
            Me_1.skill_2();
            Me_1.skill_3();
            Me_2.Hello();
            Me_2.skill_1();
            Me_2.skill_2();
            Me_2.skill_3();
            Me_3.Hello();
            Me_3.skill_1();
            Me_3.skill_2();
            Me_3.skill_3();

            Console.ReadKey();
        }
    }
}
