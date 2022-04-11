using System;

namespace _18捕获异常
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("请输入一个数字");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a * 2);
            }
            catch
            {
                Console.WriteLine("输入的内容无法转为数字");
            }
            Console.ReadKey();

        }
    }
}
