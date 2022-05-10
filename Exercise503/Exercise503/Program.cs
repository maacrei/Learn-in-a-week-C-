using System;

namespace Exercise503
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; //　配列10個
            Random rnd = new Random();
            int sum = 0;  //　合計　0は初期値
            double avg = 0.0;  //　平均　doubleでやるのがよい(整数にならない場合があるため)
            int min = 101, max = 0;  //　最小値・最大値
            for(int i = 0; i < a.Length; i++) //　forループ作成
            {
                a[i] = rnd.Next(1, 101);  //　1~100までの乱数をa[i]に代入
                Console.Write("{0} ", a[i]);
                sum += a[i];  //　合計値の更新
                if(a[i] < min)
                {
                    min = a[i]; //　最小値の更新
                }
                if(a[i] > max)
                {
                    max = a[i]; //　最大値の更新
                }
            }
            avg = sum / (double)a.Length;
            Console.WriteLine(); //　改行
            Console.WriteLine("合計値:{0} 平均値:{1} 最大値:{2} 最小値:{3}", sum, avg, max, min);
        }
    }
}
