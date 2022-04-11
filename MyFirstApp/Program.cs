using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstApp  // namespace 命名空间
{
    class Program
    {
        static void Main(string[] args)  //main 方法 ，程序路口
        {
            int age;//年龄
            age = 18;
            //age = 20;
            age = age + 1;
            Console.WriteLine("我今年{0}岁", age);
            age = age - 2;
            Console.WriteLine("我今年{0}岁", age);
        }
    }
}
