using System;

namespace _13转义字符
{
    class Program
    {
        static void Main(string[] args)
        {

            //string str = "今天天气好晴朗，\n处处好风光";
            //System.IO.File.WriteAllText(@"D:\Robam\Net_study\app1\1.txt",str);  // 把文本写入到指定路径的文件中
            //Console.WriteLine("写入成功！！！");
            //Console.ReadKey();
            Console.WriteLine(@"今天天气好晴
朗处处好风光");
            Console.ReadKey();
        }
    }
}
