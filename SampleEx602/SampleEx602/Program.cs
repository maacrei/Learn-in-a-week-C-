using System;
using System.Collections.Generic;

namespace SampleEx602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> a = new List<String>();
            //　データを追加
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            //　データを削除
            a.Remove("Taro");  //　"Taro"を削除
            a.RemoveAt(1);     //　インデックス1番目のデータを削除
            foreach (String s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
