using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    /// <summary>
    /// U盘
    /// </summary>
    class UDisk:Disk,IUSB
    {
        private string content;

        public UDisk(string _brand)
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
