﻿using System;

namespace Sample202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;  //　変数の宣言 int 整数
            int b = 3;　//　初期値と代入を同時に行う
            int add, sub;　//　複数の変数を同時に宣言
            double avg;　//　int以外の変数を宣言 double 実数
            a = 6;　//　代入（最初に値を入れるので、初期化という
            add = a + b;　//　a,bの和を求める
            sub = a - b;　//　a,bの差を求める
            avg = (a + b) / 2.0;　//　a,bの平均値を求める
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);
        }
    }
}
