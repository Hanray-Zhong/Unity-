using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoles
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe Me = new AiLuoKe("Hanray");
            Me.Hello();
            Me.SuiShiDaJi();
            Me.LieYanMaoGou();
            Me.ZhanDouPaoXiao();

            Console.ReadKey();
        }
    }
}
