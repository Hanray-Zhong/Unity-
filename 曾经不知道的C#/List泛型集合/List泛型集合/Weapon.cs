﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    class Weapon
    {
        private int id;
        private string name;
        private int attack;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public Weapon(int id, string name, int attack)
        {
            this.id=id;
            this.name=name;
            this.attack = attack;
        }

        public override string ToString()
        {
            return string.Format("id:{0},name:{1},attack:{2}", id, name, attack);
        }
    }
}
