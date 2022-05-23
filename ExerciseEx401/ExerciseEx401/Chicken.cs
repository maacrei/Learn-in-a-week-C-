using System;
namespace ExerciseEx401
{
    class Chicken : Bird
    {
        public Chicken() : base("にわとり")
        {
        }
        public override void Sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}
