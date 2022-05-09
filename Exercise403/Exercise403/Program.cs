using System;

namespace Exercise403
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
            Console.WriteLine("a={0} b={1}", a, b);
            //　回答を入力（正解出るまで繰り返す）
            while (true)
            {
                Console.Write("a+b=");
                int ans = int.Parse(Console.ReadLine());
                if(ans == a + b)
                {
                    Console.WriteLine("正解");
                    break;
                }else
                {
                    Console.WriteLine("間違い");
                }
            }
        }
    }
}
