using System;
namespace SampleEx402
{
    class Crow : Bird
    {
        //　コントラクタ
        public Crow() : base("カラス")
        {
        }
        //　カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
