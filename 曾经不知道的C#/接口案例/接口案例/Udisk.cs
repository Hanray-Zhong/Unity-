using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口案例
{
    class Udisk:IUSB

    {
        private string content;

        public void Read()
        {
            Console.WriteLine(content);
        }

        public void Write()
        {
            Console.WriteLine("输入想要写入U盘的内容：");
            content =Console.ReadLine();
        }

    }
}
