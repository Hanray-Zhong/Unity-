using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态单例设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Web w1 = new Web("百度", "www.baidu.com");
            Web w2 = new Web("哔哩哔哩", "www.bilibili.com");

            w1.Show();
            w2.Show();

            DanLi d1 = DanLi.Instance();
            DanLi d2 = DanLi.Instance();

            Console.WriteLine(d1 == d2);//输出的结果是true， 说明d1,d2是一个类


            Console.ReadKey();
        }
    }
}
