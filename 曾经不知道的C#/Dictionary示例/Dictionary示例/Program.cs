using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary示例
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化控制器对象
            PhoneController PC = new PhoneController();

            //增加电话号码
            PC.AddItem("钟子琛", "18670013148");
            PC.AddItem("hanray", "13260611711");
            PC.AddItem("中国铁路", "12306");
            Console.WriteLine("-----------------------------");

            //查询
            PC.ShowAll();
            Console.WriteLine("-----------------------------");


            //删除
            PC.DeleteNumber("hanray");
            PC.ShowAll();
            Console.WriteLine("-----------------------------");

            //修改
            PC.UpdateItem("钟子琛", "86-18670013148");
            PC.ShowAll();


            Console.ReadKey();
        }
    }
}
