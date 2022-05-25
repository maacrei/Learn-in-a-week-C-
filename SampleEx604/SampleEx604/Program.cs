using System;
using System.Collections.Generic;

namespace SampleEx604
{
    class Program
    {
        static void Main(string[] args)
        {
            //　ハッシュセットの生成(重複データは出力されない)
            HashSet<int> t = new HashSet<int>();
            //　データの追加
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);
            //　データの出力
            foreach (int i in t)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
