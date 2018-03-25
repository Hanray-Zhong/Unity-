using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户管理系统__MVC
{
    /// <summary>
    ///  C层（控制器层）
    /// </summary>
    class UserController
    {
        List<User> userList = new List<User>();

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="user"></param>
        public void AddItem(User user)
        {
            userList.Add(user);
        }


        /// <summary>
        /// 查询数据
        /// </summary>
        public void ShowItem()
        {
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i]);
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="name"></param>
        public void DeleteItem(string name)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name == name)
                {
                    userList.RemoveAt(i);
                    Console.WriteLine("删除成功！");
                }
                if (i == userList.Count - 1 && userList[i].Name != name)
                    Console.WriteLine("未搜索到对应的名字");
            }
        }

        //修改数据
        

    }
}
