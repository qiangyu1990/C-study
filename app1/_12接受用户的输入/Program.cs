using System;

namespace _12接受用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ////1.练习：问用户喜欢吃什么水果，假如用户输入了某个水果，则显示“哈哈，这么巧，我也喜欢吃苹果”
            //Console.WriteLine("美女，你喜欢吃啥子水果哟"); //打印键盘输出
            //string fruit = Console.ReadLine();  //获取键盘输入
            //Console.WriteLine("哈哈，这么巧，我也喜欢吃{0}", fruit);
            //Console.ReadKey();

            Console.WriteLine("Hello，请问您的姓名: ");
            string name = Console.ReadLine(); // 获取姓名
            Console.WriteLine("您的性别：");
            string sex = Console.ReadLine();
            Console.WriteLine("您的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("您好，尊敬的{0},年龄是{1}岁，性别{2}", name, age, sex);
        }
    }
}
