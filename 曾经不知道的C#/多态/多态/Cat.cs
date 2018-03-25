using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Cat:CatType
    {
        public override void Cray()
        {
            base.Cray();
            Console.WriteLine("喵");
        }
    }
}
