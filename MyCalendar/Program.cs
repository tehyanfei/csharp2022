using System;

namespace MyCalendar
{

    /// <summary>
    /// 全年日历
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //设定日历的长度与宽度
            const int monthwidth = 40;
            const int monthheight = 10;

            Console.Clear();

            //设置初始坐标
            int x = 0, y = 0;
            DateTime date = new DateTime(2022, 1, 1);

            //使用for循环
            for (int i = 0; i < 12; i++)
            {
                x = (i % 3) * monthwidth;
                y = (i / 3) * monthheight;


                //输出“1-12月”位置
                Console.SetCursorPosition(x, y);
                Console.Write((i + 1) + "月");


                //输出“星期日至星期六”位置
                Console.SetCursorPosition(x, y + 1);
                Console.Write("日  一  二  三  四  五  六");
            }

            do
            {
                if (date.Day == 1)
                {
                    x = ((int)date.DayOfWeek) * 4 + (date.Month - 1) % 3 * monthwidth;
                    y = (date.Month - 1) / 3 * monthheight + 2;
                    Console.SetCursorPosition(x, y);
                    Console.Write(date.Day);

                }
                else
                {
                    if ((int)date.DayOfWeek == 0)
                    {
                        x = (int)date.DayOfWeek * 4 + (date.Month - 1) % 3 * monthwidth;
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write(date.Day);

                    }
                    else
                    {
                        x += 4;
                        Console.SetCursorPosition(x, y);
                        Console.Write(date.Day);
                    }
                }
                date = date.AddDays(1);
            } while (date.Year == 2022);
            Console.WriteLine();
            Console.SetCursorPosition(1, 40);

        }


    }
}
