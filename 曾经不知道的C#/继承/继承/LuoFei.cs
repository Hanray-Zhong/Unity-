using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace 继承
{
    class LuoFei : Hero
    {
        public LuoFei()
        {

        }

        public LuoFei(string _name, string _introduction, int _attack, int _defence, int _speed, string _nickname)
            :base(_name, _introduction, _attack, _defence, _speed, _nickname)
        {

        }

        public void skill_1()
        {
            WriteLine("L技能一");
        }
        public void skill_2()
        {
            WriteLine("L技能二");
        }
        public void skill_3()
        {
            WriteLine("L技能三");
        }
    }
}
