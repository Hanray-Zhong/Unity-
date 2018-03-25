using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类案例
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNPC NPC_1 = new TaskNPC("去野外挖两根萝卜", "小白兔", NPCType.任务);
            NPC_1.SPEAK();

            ShopNPC NPC_2 = new ShopNPC("喜羊羊", "灰太狼", NPCType.商贩);
            NPC_2.SPEAK();

            Console.ReadKey();
        }
    }
}
