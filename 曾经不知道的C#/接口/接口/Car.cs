using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    /// <summary>
    /// 汽车的父类
    /// </summary>
    class Car
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Car(string _brand)
        {
            this.brand = _brand;
        }

        public void Run()
        {
            Console.WriteLine("{0} can run.",this.brand);
        }
    }
}
