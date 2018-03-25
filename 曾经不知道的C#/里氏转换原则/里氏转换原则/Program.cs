using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换原则
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、子类对象可以直接赋值给父类对象
            //2、子类对象可以调用父类的成员
            //父类对象永远只能调用自己的成员
            //3、如果父类对象中装的是子类对象，则可以将这个父类对象强制转换为子类对象
            
            //before
            Cat cat = new Cat();
            cat.Cray();
            cat.MKCODE();

            Console.WriteLine("______________________");

            //new
            CatType _cat = new Cat();
            _cat.Cray();

            Cat new_cat = (Cat)_cat;//强制类型转换
            new_cat.MKCODE();

            //is:转换成功/失败，返回true/false
            bool judge_1 = _cat is Cat;
            bool judge_2 = _cat is Tiger;
            Console.WriteLine("_cat is Cat:{0}\nnew_cat is Tiger:{1}", judge_1, judge_2);

            //as:转换成功/失败，返回对应的对象/null



            Console.ReadKey();
        }
    }
}
