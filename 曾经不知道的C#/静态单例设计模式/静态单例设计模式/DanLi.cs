using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态单例设计模式
{
    class DanLi
    {
        //1、声明一个静态且私有的这么一个当前类类型的字段
        private static DanLi instance;
        //2、创建私有的无参构造方法，保证外部无法实例化这个类
        private DanLi()
        {

        }
        //3、创建一个静态的方法，用于创建此类的唯一对象
        public static DanLi Instance()
        {
            if(instance == null)
            {
                instance = new DanLi();
            }
            return instance;
        }
    }
}
