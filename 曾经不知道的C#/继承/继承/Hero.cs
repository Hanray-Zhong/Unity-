using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{

   public class Hero
    {
        private string name;
        private string introduction;
        private int attack;
        private int defence;
        private int speed;
        private string nickname;

        public Hero()
        {

        }

        public Hero(string _name, string _introduction, int _attack, int _defence, int _speed, string _nickname)
        {
            this.name = _name;
            this.introduction = _introduction;
            this.attack = _attack;
            this.defence = _defence;
            this.speed = _speed;
            this.nickname = _nickname;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Introduction
        {
            get { return introduction; }
            set { introduction = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string NickName
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public void Hello()
        {
            Console.WriteLine("我是{0}，{1}，我的攻击力为{2}，防御力为{3}，速度为{4}，昵称为{5}", this.name, this.introduction, this.attack, this.defence, this.speed, this.nickname);
        }

    }
}
