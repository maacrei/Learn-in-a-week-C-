using System;

namespace ExerciseEx201
{
    class Program
    {
        //　ベクトルの内容を表示するメソッド
        static void Show(string name, Vector2D v)
        {
            Console.WriteLine("{0}=({1}, {2})", name, v.X, v.Y);
        }
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D(1.0, 1.0);
            Show("v1", v1);  //　v1=(1,1)と表示
            Vector2D w = new Vector2D(1.0, -1.0);
            Vector2D v2 = new Vector2D(w);
            //上記2行を追加編集　この記述は不要になる→　v2.X = 1.0; v2.Y = -1.0;
            Show("v2", v2);  //　v2=(1,-1)と表示
            //  v1+c2
            v1.Add(v2);
            Show("v1", v1);  //　v1=(2,0)と表示
            //  v1-c2
            v1.Sub(v2);
            Show("v1", v1);  //　v1=(1,1)と表示
            //  2*v1
            v1.Mul(2.0);
            Show("v1", v1);  //　v1=(2,2)と表示
            //  v1,v2の内積
            Console.WriteLine("v1,v2の内積:{0}", v1.DotProduct(v2));  // 2*1+2*-1=0となる
            //上から順に計算している
        }
    }
}

