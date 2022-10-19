using System;
using MyEncoder;

namespace Vigenere
{
    internal class Program
    {
        /// <summary>
        /// 维吉尼亚加密法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //用户输入明文和密钥
            Console.WriteLine("请输入明文：");
            string plain = Console.ReadLine();
            Console.WriteLine("请输入密钥");
            string key = Console.ReadLine();

            //加密
            Encoder myencoder = new Encoder();
            myencoder.Plaintext = plain;
            myencoder.Key = key;
            myencoder.MyEncoder();

            //输出密文
            Console.WriteLine($"密文是：{myencoder.Cipher}");

        }
    }
}