using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱与拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("钟子琛", 18, "长沙");
            p1.Hello();
            Console.WriteLine(p1.ToString());


            //两种关系，只有存在继承的关系时，才能有装箱和拆箱的操作
            int a = 10;
            object b = a;               //装箱操作，将值类型->引用类型
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = (int)b;                 //拆箱操作，将引用类型->值类型
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();
        }
    }
}
