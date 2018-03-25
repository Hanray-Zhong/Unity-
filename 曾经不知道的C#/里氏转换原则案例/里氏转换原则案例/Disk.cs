using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则案例
{
    /// <summary>
    /// 存储设备的父类
    /// </summary>
    class Disk
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Disk(string _brand)
        {
            this.brand = _brand;
        }

    }
}
