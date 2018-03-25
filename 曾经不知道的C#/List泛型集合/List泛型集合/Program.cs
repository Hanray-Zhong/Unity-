using System;
using System.Collections.Generic;//包含了List泛型集合
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化一个List
            List<int> number = new List<int>();

            //添加数据.
            number.Add(5);
            number.Add(15);
            number.Add(25);
            number.Add(35);

            //读取数据
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }

            //删除数据
            Console.WriteLine("-----------------");
            number.RemoveAt(2);
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }

            //修改数据
            number[2] = 100;
            Console.WriteLine("-----------------");
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }

            //----------------------------------------
            Console.WriteLine("----------------------------");
            //定义武器的集合
            List<Weapon> weapons = new List<Weapon>();
            //定义一把武器
            Weapon item = new Weapon(1, "霸王枪", 100);

            weapons.Add(item);
            weapons.Add(new Weapon(2, "翡翠枪", 150));
            weapons.Add(new Weapon(3, "上古卷轴", 1000));
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine(weapons[i]);
            }



            Console.ReadKey();
        }
    }
}
