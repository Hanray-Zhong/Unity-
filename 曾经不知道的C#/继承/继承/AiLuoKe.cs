using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 继承
{
    class AiLuoKe : Hero
    {
        public AiLuoKe()
        {

        }

        public AiLuoKe(string _name, string _introduction, int _attack, int _defence, int _speed, string _nickname)
            :base(_name, _introduction, _attack, _defence, _speed, _nickname)
        {

        }//上传给父类进行初始化

        public void skill_1()
        {
            WriteLine("A技能一");
        }
        public void skill_2()
        {
            WriteLine("A技能二");
        }
        public void skill_3()
        {
            WriteLine("A技能三");
        }
    }
}
