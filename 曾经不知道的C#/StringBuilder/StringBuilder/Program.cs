using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder SB = new StringBuilder();
            Stopwatch SW = new Stopwatch();

            SW.Start();
            SB.Append("hanray");
            SB.Append(123456);
            SB.Append(true);       //StringBuilder 数据的追加。

            WriteLine(SB.ToString());

            SB.Clear();            //StringBuilder 数据的清空
            WriteLine(SB.ToString());
            SW.Stop();

            WriteLine(SW.Elapsed);

            string myString="";
            for (int i = 1; i <= 90000; i++)
                myString += Convert.ToString(i);    //21.8s

            SW.Start();
            for (int i = 1; i <= 90000; i++)
                SB.Append(i);                       //0.051s
            SW.Stop();

            WriteLine(SW.Elapsed);
            
            ReadKey();
        }
    }
}
