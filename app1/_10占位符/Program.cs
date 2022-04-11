using System;

namespace _10占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 12;
            int num3 = 13;
            Console.WriteLine("第一个数字是:" +num1+"第二个数字是"+num2+"第三个数字是"+num3);
            Console.WriteLine("第一个数字是{0},第二个数字是{2},第三个数字是{1}", num1,num2,num3);  //占位符的使用
            //占位符是使用规则，几个占位符就要跟几个变量
            Console.ReadKey();
        }
    }
}
