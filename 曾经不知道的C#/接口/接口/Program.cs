using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW car_1 = new BMW("BMW750");
            car_1.Run();
            BMW car_2 = new BMW("BMW740");
            car_2.Run();

            BatMobile Bat_1 = new BatMobile("蝙蝠侠战车1");
            Bat_1.Run();
            Bat_1.Fly();


            Console.ReadKey();
        }
    }
}
