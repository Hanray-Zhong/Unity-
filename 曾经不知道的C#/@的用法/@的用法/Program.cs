using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"G:\学习\计算机\Unity\Unity学习\曾经不知道的C#";
            /*1、取消\在字符串中的转义作用
              2、将字符串按照原格式输出
            */
            WriteLine(Path);
            WriteLine(@"My name is Hanray.");
            ReadKey();
        }
    }
}
