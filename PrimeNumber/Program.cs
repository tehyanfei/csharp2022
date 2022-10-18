using System;

namespace PrimeNumber
{

    /// <summary>
    /// 输出10万以内，共有的质数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int flag = 0;

            //使用for循环
            //初始化变量b，判断b的条件，符合条件执行循环体
            for (int b = 2; b <= 100000; b++)
            {
                //初始化变量a,判断a是否小于等于b
                for (int a = 2; a < b; a++)
                {
                    //假设b可以整除a，即取余为0表示可以整除，flag计数为1
                    if (b % a == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                //如果flag为0，则该数确认为质数，计数加1
                if (flag == 0)
                {
                    count++;
                }
                flag = 0;
            }
            Console.WriteLine(count);
        }
    }

}