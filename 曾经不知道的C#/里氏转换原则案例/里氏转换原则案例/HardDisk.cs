using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    /// <summary>
    /// 硬盘
    /// </summary>
    class HardDisk:Disk,IUSB
    {
        private string content;

        public HardDisk(string _brand)
            :base(_brand)
        {

        }

        public void Read()
        {
            Console.WriteLine("{0}的数据：{1}", base.Brand, content);
        }

        public void Write(string content)
        {
            this.content = content;
        }
    }
}
