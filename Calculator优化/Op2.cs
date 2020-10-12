using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Op2:Add
    {
        public override void  Add()
        {
            Console.WriteLine("输入第一个字符串为：");
            String a = Console.ReadLine();
            Console.WriteLine("输入的第二个字符串为：");
            String b = Console.ReadLine();
            string ca = a + b;
            Console.WriteLine("输入的两个字符串相连为：{0}",ca);
        }
        public override void Sub()
        {
            Console.WriteLine("输入第一个字符串为：");
            string a = Console.ReadLine();
            Console.WriteLine("输入的第二个字符串为：");
            string b = Console.ReadLine();
            string str = System.Text.RegularExpressions.Regex.Replace(a, b, "");
            Console.WriteLine("输入的两个字符串相减为：{0}", str);
        }
    }
}
