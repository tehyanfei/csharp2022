using System;

namespace TowerOfHanoi
{

    /// <summary>
    /// 输出汉诺塔,将柱A的盘子转移到柱C
    /// </summary>
    /// <param name="args"></param>
    class Program
    {

        static void Main(string[] args)

        {
            //输入汉诺塔的层数
            Console.WriteLine("请输入汉诺塔的层数");
            int number = Convert.ToInt32(Console.ReadLine());

            //设置柱子编号
            Move(number, "A", "B", "C");
        }

        //定义汉诺塔递归函数
        public static void Move(int number, string A, string B, string C)
        {
            if (number == 1)
            {
                Console.WriteLine($"将第{number}个盘子从{A}柱移到{C}柱上");
            }
            else
            {
                //将number-1个盘子，从A柱经过C柱移到B柱
                Move(number - 1, A, C, B);
                Console.WriteLine($"将第{number}个盘子从{A}柱移到{C}柱上");
                //将number-1个盘子，从B柱移到C柱
                Move(number - 1, B, A, C);
            }

        }

    }
}


