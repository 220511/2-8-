using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要进行的运算符号（+，-，*，/）:");
            Op1 op1 = new Op1();
            Op2 op2 = new Op2();
            string c = Console.ReadLine();
            if (c == "+")
            {
                op1.Add();
                op1.Equals();
                op2.Add();
            }
            else if (c == "-")
            {
                op1.Sub();
                op1.Equals();
                op2.Sub();
            }
            else if (c == "*")
            {
                op1.Mul();
                op1.Equals();
            }
            else if (c == "/")
            {
                op1.Div();
                op1.Equals();
            }
        }
    }
}
