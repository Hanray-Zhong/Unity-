using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆栈关系
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Me = new Person("Hanray", 19, Person.Gender.男);
            Person Me_ = Me;//看作是一个指针，Person命名后的值储存的是一个地址，即栈空间

            Me.Introduce();
            Me_.Introduce();

            Me_.name = "钟子琛";

            Me.Introduce();
            Me_.Introduce();

            Console.ReadKey();

        }
    }
}
