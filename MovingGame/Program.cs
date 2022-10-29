using System;

namespace MovingGame
{

    /// <summary>
    /// 光标游戏
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //First,int x,y is original position
            int x = 0, y = 0;
            ConsoleKey input;

            do
            {
                //output a string at position x.y
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("Hello");

                //get user input using Console.Readkey
                input = Console.ReadKey(true).Key;

                //change x,y according to user input
                switch (input)
                {
                    case ConsoleKey.Enter:
                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                }
                //back to step 2
            } while (input != ConsoleKey.Enter);

        }
    }
}
