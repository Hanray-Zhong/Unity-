using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface IFly
    {
        //接口中不能包含字段，但可以包含属性
        //接口中的所有成员不允许添加访问修饰符，所有成员默认为public
        //接口中的方法不能有方法体，不能有访问修饰符，默认是public
        //接口中的所有方法都是抽象方法
        void Fly();
    }
}
