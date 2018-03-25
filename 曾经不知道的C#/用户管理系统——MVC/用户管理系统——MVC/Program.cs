using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户管理系统__MVC
{
    class Program
    {
        /// <summary>
        /// V层（视图层）
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--------用户管理系统--------");
            Console.WriteLine("---------------------------");

            UserController uc = new UserController();

            //接受用户输入的信息
            while (true)
            {
                Console.WriteLine("请输入相应的指令：\n1-增加\n2-修改\n3-删除\n4-查看");//提示用户可以操作的类型
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        Console.WriteLine("增加");
                        Console.Write("请输入名字：");
                        string name = Console.ReadLine();
                        Console.Write("请输入年龄：");
                        int age = int.Parse(Console.ReadLine());//输入的强制转化
                        Console.Write("请输入地址：");
                        string address = Console.ReadLine();
                        uc.AddItem(new User(name, age, address));
                        break;

                    case "2":
                        Console.WriteLine("修改");
                        break;

                    case "3":
                        Console.WriteLine("删除");
                        Console.Write("请输入你想要删除的名字：");
                        string delete_name = Console.ReadLine();
                        uc.DeleteItem(delete_name);
                        break;

                    case "4":
                        Console.WriteLine("查看");
                        uc.ShowItem();
                        break;

                    default:
                        Console.WriteLine("请输入指定的指令");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
