using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            string num_1, num_2;
            WriteLine("Please input 2 numbers:");
            num_1 = ReadLine();
            num_2 = ReadLine();
            int max, min, sum;
            double avg;
            NumberFuction(ToInt32(num_1), ToInt32(num_2), out max, out min, out sum, out avg);
            WriteLine($"max={max}\nmin={min}\nsum={sum}\navg={avg}");
            ReadKey();

        }

        static void NumberFuction(int num_1, int num_2, out int max, out int min, out int sum, out double avg)
        {
            if(num_1>num_2)
            {
                max = num_1;
                min = num_2;
            }
            else
            {
                max = num_2;
                min = num_1;
            }
            sum = num_1 + num_2;
            avg = ToDouble(sum) / 2;
        }

    }
}
