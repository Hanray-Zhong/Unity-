using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoles
{
    public class AiLuoKe
    {
        private string name = "艾洛克";
        private string introduction = "伟大的战士.......";
        private string nickName;
        private double attack = 100;
        private double defend = 65;
        private double speed = 40;

        public AiLuoKe()
        {
        }

        public AiLuoKe(string nickname)
        {
            this.nickName = nickname;
        }

        public string Name
        {
            get { return name; }
        }

        public string Introduction
        {
            get { return introduction; }
        }

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        public double Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public double Deffend
        {
            get { return defend; }
            set { defend = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void SuiShiDaJi()
        {
            Console.WriteLine("碎石打击");
        }
        public void LieYanMaoGou()
        {
            Console.WriteLine("烈焰锚钩");
        }
        public void ZhanDouPaoXiao()
        {
            Console.WriteLine("战斗咆哮");
        }

        public void Hello()
        {
            Console.WriteLine("我叫{0}，{1}，我的昵称是{5}, 我的攻击力为{2}，防御力为{3}，速度为{4}.", name, introduction, attack, defend, speed, nickName);
        }

    }
}
