using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 重载函数
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("3+7=" + AddFunction(3, 7));
            WriteLine("3.14159+3.17=" + AddFunction(3.14159 , 3.17));
            WriteLine("3.14159+10=" + AddFunction(3.14159, 10));
            ReadKey();
        }
        
        static int AddFunction(int a,int b)
        {
            return a + b;
        }

        static double AddFunction(double a,double b)
        {
            return a + b;
        }

        static double AddFunction(double a, int b)
        {
            return a + b;
        }
    }
}
