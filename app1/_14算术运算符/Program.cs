using System;

namespace _14算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //double b = 3.2;
            //double c = a + b;  //c是整数3,不是3.33
            //Console.WriteLine("c等于{0}", c);
            int n1 = 10;
            int n2 = 3;
            double d = n1 * 1.0 / n2;
            Console.WriteLine("{0:0.00}", d);
            Console.ReadKey();


        }
    }
}
