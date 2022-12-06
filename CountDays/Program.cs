using System;

///计算本世纪开始到现在总共过了多少天

internal class Program
{
    private static void Main(string[] args)
    {
        TimeSpan ts = DateTime.Today - new DateTime(2000, 1, 1);
        Console.WriteLine($"这个世纪已经过了{ts}天");

    }
}