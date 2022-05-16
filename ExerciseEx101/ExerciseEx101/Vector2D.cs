using System;
namespace ExerciseEx101
{
    public class Vector2D
    {
        //ここから
        public Vector2D()
        {
        }
        public Vector2D(double x, double y)
        {
            X = x; Y = y;
        }
        public Vector2D(Vector2D v)
        {
            X = v.X; Y = v.Y;
        }
        //ここまで追加
        public void Add(Vector2D v)
        {
            X += v.X; Y += v.Y;
        }
        public void Sub(Vector2D v)
        {
            X -= v.X; Y -= v.Y;
        }
        public void Mul(double k)
        {
            X *= k; Y *= k;
        }
        public double DotProduct(Vector2D v)
        {
            return X * v.X + Y * v.Y;
        }
        //プロパティを追加
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
    }

}
