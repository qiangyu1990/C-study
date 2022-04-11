using System;

namespace _19switch_case语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入员工的代号：");
            //string name = Console.ReadLine();
            //int salary = 3500;
            //bool b = true;
            //switch (name)
            //{
            //    case "A":
            //        salary +=1500;
            //    break;

            //    case "B":
            //        salary += 1000;
            //        break;
            //    case "C":
            //        salary += 500;
            //        break;
            //    case "D":
            //        salary += 100;
            //        break;
            //    default:   // 都不满足以上情况，则只需这条语句
            //        Console.WriteLine("您输入的内容不再考虑的范围里");
            //        b = false;  //当不在上述情况下，不做薪水输出
            //        break;    
            //}
            //if (b)
            //{
            //    Console.WriteLine("该员工{0}的薪水是{1}", name, salary);
            //}


            //请输入年份和月份，输出该月份的天数，注意这里要判断是否是闰年
            //闰年是4的倍数，且不是100的倍数。或者是400的倍数

            Console.WriteLine("请输入年份：");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("请输入月份：");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());

                    
                    switch (month)
                    {
                        case 2:
                            if ((year % 4 == 0) && (year % 100 != 0) || year % 400 == 0)
                            { Console.WriteLine("该月份的天数是29"); }
                            else { Console.WriteLine("该月份的天数是28"); }
                            break;
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("该月份的天数是31");
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("该月份的天数是30");
                            break;
                        default:
                            Console.WriteLine("您输入月份有误");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入月份异常，请检查");
                }
            }
            catch
            {
                Console.WriteLine("输入年份异常，请检查");
            }
        }
    }
}
