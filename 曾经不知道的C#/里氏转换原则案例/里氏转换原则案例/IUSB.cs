using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    interface IUSB
    {
        void Read();
        void Write(string content);
    }
}
