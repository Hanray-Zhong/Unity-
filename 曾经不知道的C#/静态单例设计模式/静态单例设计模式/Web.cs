using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态单例设计模式
{
    class Web
    {
        private string webName;
        private string webUrl;

        public Web(string _webname, string _webUrl)
        {
            this.webName = _webname;
            this.webUrl = _webUrl;
        }

        public void Show()
        {
            Console.WriteLine("名字：{0}，地址：{1}.", webName, webUrl);
        }

    }
}
