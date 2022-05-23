using System;
namespace SampleEx402
{
    class Sparrow : Bird
    {
        //　コントラクタ
        public Sparrow() : base("すずめ")
        {
        }
        //　すずめが鳴く
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
