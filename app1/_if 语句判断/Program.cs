using System;

namespace _if_语句判断
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //if else-if 结构
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >90)
            {
                Console.WriteLine("恭喜你的得分评：A");
            }
            else if(80<a && a<=90)
            { Console.WriteLine("恭喜你的得分评：B"); 
            }
            else if(a>70 && a <= 80)
            {
                Console.WriteLine("恭喜你的得分评：C");
            }
            else { Console.WriteLine("恭喜你的得分评：D"); 
            }
            Console.ReadKey();
        }
    }
}
