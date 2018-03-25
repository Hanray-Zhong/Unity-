using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    /// <summary>
    /// 蝙蝠侠的战车
    /// </summary>
    class BatMobile:Car,IFly
    {
        public BatMobile(string _brand)
            : base(_brand)
        {

        }

        public void Fly()
        {
            Console.WriteLine("{0} can fly.",base.Brand);
        }
    }
}
