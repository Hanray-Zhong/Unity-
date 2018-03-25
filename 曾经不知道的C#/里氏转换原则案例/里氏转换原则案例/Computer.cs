using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    class Computer
    {
        public IUSB USB_1;
        public IUSB USB_2;


        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Computer(string _brand)
        {
            this.brand = _brand;
        }

        public void Start()
        {
            Console.WriteLine("{0}开机", brand);
        }

        public void End()
        {
            Console.WriteLine("{0}关机", brand);
        }
    }
}
