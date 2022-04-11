using System;

namespace _3_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 显示类型转换、自动类型转换
            //string s = "123";
            //// 将字符串转换成int或者double类型
            //int d = Convert.ToInt32(s);
            //Console.WriteLine("{0}转换int成功", d);
            //double n = Convert.ToDouble(s);
            //Console.WriteLine("{0}转换double成功", n);
            //Console.ReadKey();


            //让用户输入姓名、语文、数学、英文 三门课的成绩
            //    然后给用户显示： XX,你的总成绩为XX分，平均成绩为XX分。
            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("输入语文成绩：");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("输入数学成绩：");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("输入英文成绩:");
            //string strEnglish = Console.ReadLine();

            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);

            //Console.WriteLine("{0}的总成绩{1}，平均成绩{2}", name,chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadLine();

            //提示用户输入一个数字，然后2倍打印输出
            Console.WriteLine("请输入一个数字：");

            double Doublestring = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Doublestring*2);
            Console.ReadKey();
        }
    }
}
