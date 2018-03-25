using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类案例
{
    class TaskNPC:NPC
    {
        private string taskInfo;

        public TaskNPC(string _taskInfo, string _name, NPCType _type)
            :base(_name,_type)
        {
            this.taskInfo = _taskInfo;
        }

        public override void SPEAK()
        {
            Console.WriteLine("NPC：{0}，任务：{1}",base.Name,this.taskInfo);
        }

    }
}
