using System;
namespace Sample602
{
    public class Calc
    {
        //複数の同じ名前のメソッド(今回の場合はAdd)を作成することをオーバーロードという
        //　二つの整数の引数の和を求める
        public int Add(int a, int b)
        {
            return a + b;
        }
        //　三つの整数の引数の和を求める
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
