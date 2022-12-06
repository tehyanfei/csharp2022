using System.Text;

namespace Calendar

{
    internal class Program
    {
        /// <summary>
        /// 2022 Calendar
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int x = 0, y = 0;
            ///预设每个月的长和宽
            int MonthHeight = 9, Monthwidth = 40;
            for (int Month = 1; Month <= 12; Month++)
            {

                //输出每个月的月份和星期
                Console.Write($"           {Month}月");
                Console.SetCursorPosition(x, y + 1);
                Console.Write("日  一  二  三  四  五  六");

                //输出每月的日期
                DateTime theday = new DateTime(2022, Month, 1);
                //判断每月的第一天是星期几
                int Thefirstday = (int)theday.DayOfWeek;
                Console.SetCursorPosition(x + 4 * Thefirstday, y + 2);
                int y1 = y + 2;
                for (int i = 1; i <= DateTime.DaysInMonth(2022, Month); i++)
                {
                    //遇到星期日就换行
                    // int a = 0;
                    DateTime Day = new DateTime(2022, Month, i);
                    int Everyday = (int)Day.DayOfWeek;

                    if (Day.DayOfWeek == DayOfWeek.Sunday)
                    {
                        y1++;
                        Console.SetCursorPosition(x + 4 * Everyday, y1);
                        Console.Write(i);

                    }


                    else
                    {
                        Console.SetCursorPosition(x + 4 * Everyday, y1);
                        Console.Write(i);

                    }
                }
                //设定每月的位置
                if (Month % 3 == 0)
                {
                    x = 0; y += MonthHeight;
                }
                else
                {
                    x += Monthwidth;
                }
                Console.SetCursorPosition(x, y);
            }
            Console.ReadKey();

        }
    }
}