using System;

namespace _15算术两道作业题
{
    class Program
    {
        static void Main(string[] args)
        {
            // 练习，编程实现计算几天(如46天)是几周几天
            //int days = 46;
            //int weeks = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);
            //Console.ReadKey();

            //编程实现107653秒是几天几小时几分钟几秒

            int seconds = 89340;
            int days = seconds / 86400;
            int hours = (seconds % 86400) / 3600;
            int mins = ((seconds % 86400) % 3600) /60;
            int secs = ((seconds % 86400) % 3600) % 60;
            Console.WriteLine("{0}是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, mins, secs);
        }
    }
}
