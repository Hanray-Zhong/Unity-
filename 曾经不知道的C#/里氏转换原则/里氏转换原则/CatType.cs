using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则
{
    class CatType
    {
        public virtual void Cray()
        {
            Console.WriteLine("I can cray.");
        }

        public void MKCODE()
        {
            Console.WriteLine("我是父类");
        }
    }
}
