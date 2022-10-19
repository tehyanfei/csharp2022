using System;

namespace ReactionTest
{

    /// <summary>
    /// ReactionTest
    /// </summary>
    class Program


    {
        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        static void Main(string[] args)
        {

            //测试的总数=10
            const int countOfTest = 10;

            //平均反应时间
            double ReactionTime = 0;
            DateTime StartTime = DateTime.Now;
            int countOfError = 0;
            Random rnd = new Random();


            for (int i = 1; i < countOfTest; i++)
            {
                Console.Clear();
                Console.WriteLine($"第{i}次测试，总耗时{ReactionTime}秒,总共答错{countOfError}题");

                Direction direction = (Direction)rnd.Next(0, 4);
                Console.WriteLine(direction.ToString());

                var key = Console.ReadKey();
                switch (direction)
                {
                    case Direction.Up:
                        if (key.Key == ConsoleKey.UpArrow)
                            break;
                        else countOfError++;
                        break;

                    case Direction.Down:
                        if (key.Key == ConsoleKey.DownArrow)
                            break;
                        else countOfError++;
                        break;

                    case Direction.Left:
                        if (key.Key == ConsoleKey.LeftArrow)
                            break;
                        else countOfError++;
                        break;

                    case Direction.Right:
                        if (key.Key == ConsoleKey.RightArrow)
                            break;
                        else countOfError++;
                        break;
                    default:
                        break;


                }

            }

            //计算测试使用时间
            DateTime EndingTime = DateTime.Now;
            var TestTime = EndingTime.Subtract(StartTime);
            Console.Write($"总共用时{TestTime}");

        }
    }
}


