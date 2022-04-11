using System;

namespace _20断点调试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入员工的代号：");
            string name = Console.ReadLine();
            int salary = 3500;
            bool b = true;
            switch (name)
            {
                case "A":
                    salary += 1500;
                    break;
                case "B":
                    salary += 1000;
                    break;
                case "C":
                    salary += 500;
                    break;
                case "D":
                    salary += 100;
                    break;
                default:   // 都不满足以上情况，则只需这条语句
                    Console.WriteLine("您输入的内容不再考虑的范围里");
                    b = false;  //当不在上述情况下，不做薪水输出
                    break;
            }
            if (b)
            {
                Console.WriteLine("该员工{0}的薪水是{1}", name, salary);
            }

        }
    }
}
