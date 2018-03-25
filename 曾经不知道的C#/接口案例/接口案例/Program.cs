using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口案例
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person Me = new Person();
            Console.WriteLine(Me.Name);
            Me.Age = 18;
            Console.WriteLine(Me.Age);
            */

            Udisk u = new Udisk();
            u.Write();
            u.Read();

            Console.ReadKey();
        }
    }
}
