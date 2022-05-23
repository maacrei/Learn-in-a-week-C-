using System;
namespace ExerciseEx401
{
    class Sparrow : Bird
    {
        public Sparrow() : base("すずめ")
        {
        }
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
