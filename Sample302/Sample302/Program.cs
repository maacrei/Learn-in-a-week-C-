﻿using System;

namespace Sample302
{
    class Program
    {
        static void Main(string[] args)
        {
            //　キーワードから数値を入力
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);
            //　入力した値が、正の数かどうかを調べる
            if (a > 0)
            {
                Console.WriteLine("aは正の数です。"); //　正の数だった場合に実行
            }
            else
            {
                Console.WriteLine("aは正の数ではありません。");
            }
        }
    }
}
