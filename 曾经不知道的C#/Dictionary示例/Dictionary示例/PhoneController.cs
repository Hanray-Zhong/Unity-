using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary示例
{
    /// <summary>
    /// C层
    /// </summary>
    class PhoneController
    {
        /// <summary>
        /// 电话号码字典集合
        /// </summary>
        Dictionary<string, string> phone = new Dictionary<string, string>();

        /// <summary>
        /// 添加号码到字典集合
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="number">电话号码</param>
        public void AddItem(string name, string number)
        {
            phone.Add(name, number);
        }

        /// <summary>
        /// 输出所有的数据
        /// </summary>
        public void ShowAll()
        {
            foreach (var item in phone)
            {
                Console.WriteLine("名字：{0}--号码：{1}",item.Key, item.Value);
            }
        }

        /// <summary>
        /// 按名字删除数据
        /// </summary>
        /// <param name="name">名字</param>
        public void DeleteNumber(string name)
        {
            if (phone.Remove(name) == true)
                Console.WriteLine("删除成功！");
            else
                Console.WriteLine("未查询到数据...");
        }

        /// <summary>
        /// 按名字修改数据
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="new_number">新电话号码</param>
        public void UpdateItem(string name, string new_number)
        {
            phone[name] = new_number;
        }

    }
}
