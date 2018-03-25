using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.Cray();

            Cat cat = new Cat();
            cat.Cray();

            Console.ReadKey();
        }
    }
}
