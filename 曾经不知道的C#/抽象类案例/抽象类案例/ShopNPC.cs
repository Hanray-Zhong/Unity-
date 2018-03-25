using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类案例
{
    class ShopNPC:NPC
    {
        private string item;
        public ShopNPC(string _item, string _name, NPCType _type)
            :base(_name, _type)
        {
            this.item = _item;
        }

        public override void SPEAK()
        {
            Console.WriteLine("NPC：{0}，商品：{1}", base.Name, this.item);
        }

    }
}
