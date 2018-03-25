using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary泛型类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("英文名", "hanray");
            dic.Add("中文名", "钟子琛");
            dic.Add("baidu", "百度");

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            
            //删除
            dic.Remove("中文名");
            foreach (var item in dic.Values)//只输出值
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");

            //修改
            dic["baidu"] = "www.baidu.com";
            foreach (var item in dic.Keys)//只输出建
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}
