using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    class Program
    {
        static void Main(string[] args)
        {
            UDisk u1 = new UDisk("Kingston 32G");

            HardDisk h1 = new HardDisk("WD 1TB");

            Computer c1 = new Computer("Lenovo");
            c1.Start();
            c1.USB_1 = u1;
            c1.USB_1.Write("金士顿32GU盘");
            c1.USB_1.Read();
            c1.End();

            Console.WriteLine("——————————————————————");

            Computer c2 = new Computer("DELL");
            c2.Start();
            c2.USB_2 = h1;
            c2.USB_2.Write("西数1T硬盘");
            c2.USB_2.Read();
            c2.End();

            


            Console.ReadKey();
        }
    }
}
