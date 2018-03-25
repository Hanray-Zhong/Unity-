using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类案例
{
    /// <summary>
    /// NPC的任务类型
    /// </summary>
    enum NPCType
    {
        任务,
        商贩,
        铁匠,
    }
    abstract class NPC
    {
        private string name;
        private NPCType type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public NPCType Type
        {
            get { return type; }
            set { type = value; }
        }

        public NPC()
        {

        }

        public NPC(string _name,NPCType _type)
        {
            this.name = _name;
            this.type = _type;
        }

        public abstract void SPEAK();

    }
}
