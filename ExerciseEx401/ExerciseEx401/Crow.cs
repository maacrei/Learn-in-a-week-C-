using System;
namespace ExerciseEx401
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
