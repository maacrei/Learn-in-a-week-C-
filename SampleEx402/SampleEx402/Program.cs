using System;

namespace SampleEx402
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird[] b = new Bird[2];　//　Birdクラスの変数の配列を生成
            b[0] = new Crow();
            b[1] = new Sparrow();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}
