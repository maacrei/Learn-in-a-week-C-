using System;
using System.Collections.Generic;

namespace ExerciseEx602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            while (true)
            {
                Console.Write("1~10の整数を入力:");
                int num = int.Parse(Console.ReadLine());
                if (num < 1 || num > 10)
                {
                    break;  //　範囲外であればループから抜ける
                }
                l.Add(num);
            }
            //　lの並べ替え(小さい順にしかできない)
            l.Sort();
            l.Reverse(); //　順序を逆転
            foreach (int n in l)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
