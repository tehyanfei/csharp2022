using System;

namespace CSharpOne
{

    /// <summary>
    /// 输出直角三角形
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string stars = "*";
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(stars);
                stars += "*";
            }
        }
    }

}