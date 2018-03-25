using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 处理字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "hanray";
            string anotherString = "zhong";

            //ToUpper(); 改大写
            //ToLower(); 改小写

            WriteLine("Equals:" + anotherString.Equals(myString));

            char[] c = new char[] { '|' };
            string Location = "中国|湖南|长沙|岳麓区";
            string[] str = Location.Split(c);
            foreach(string s in str)
            {
                WriteLine(s);
            }

            WriteLine("Substring:" + myString.Substring(3));
            WriteLine("Substring:" + myString.Substring(3, 2));   //从。。。截取。。。个字符并返回

            WriteLine("IndexOf('h'):" + myString.IndexOf('h'));
            WriteLine("LastIndexOf('a'):" + myString.LastIndexOf('a'));

            WriteLine("StartsWith(\"ha\"):" + myString.StartsWith("ha"));
            WriteLine("EndsWith(\"y\"):" + myString.EndsWith("y"));

            WriteLine("Replace: \"" + Location.Replace("|", "\" \"") + "\"");

            WriteLine("Contains:" + myString.Contains("han"));

            string Blank = "     hanray     ";
            WriteLine("\n|" + Blank + "|");
            WriteLine("Trim():|" + Blank.Trim() + "|");
            WriteLine("TrimEnd():|" + Blank.TrimEnd() + "|");
            WriteLine("TrimStart():|" + Blank.TrimStart() + "|");

            string NullOrEmpty = "";
            WriteLine("string.IsNullOrEmpty:" + string.IsNullOrEmpty(NullOrEmpty));

            ReadKey();
        }
    }
}
