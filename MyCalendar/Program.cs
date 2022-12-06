using System;

namespace MyCalendar
{

    /// <summary>
    /// 输出2022全年日历
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //设定日历的长度与宽度
            const int monthwidth = 80;
            const int monthheight = 10;

            Console.Clear();

            //设置初始坐标
            int x = 0, y = 0;
            DateTime date = new DateTime(2022, 1, 1);

            //使用for循环
            for (int month = 0; month < 13; month++)
            {
                x = ((month-1) % 3) * monthwidth;
                y = ((month-1) / 3) * monthheight;

                //输出“1-12月”位置
                Console.SetCursorPosition(x+20, y);
                Console.Write($"{month}月");


                //输出“星期日至星期六”位置
                Console.SetCursorPosition(x, y + 1);
                Console.Write("日  一  二  三  四  五  六");
            }
            //定义日期的行和列
            int row = 0, col = 0;

            do
            {
                //输出每个月的1号
                if (date.Day == 1)
                {
                    row = (date.Month - 1) % 3 * monthwidth + ((int)date.DayOfWeek) * monthwidth;
                    col = (date.Month - 1) / 3 * monthheight + 2;
                    Console.SetCursorPosition(row, col);
                    Console.Write("1");

                }
                else
                {
                    if ((int)date.DayOfWeek == 0)
                    {
                        row = (int)date.DayOfWeek * 4 + (date.Month - 1) % 3 * monthwidth;
                        col++;
                        Console.SetCursorPosition(x, y);
                        Console.Write(date.Day);

                    }
                    else
                    {
                        row += 4;
                        Console.SetCursorPosition(x, y);
                        Console.Write(date.Day);
                    }
                }
                date = date.AddDays(1);
            } while (date.Year == 2022);
            Console.WriteLine();
            Console.SetCursorPosition(0, 40);

        }


    }
}
