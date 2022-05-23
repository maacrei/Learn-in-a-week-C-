using System;
namespace SampleEx403
{
    //　スーパークラス（抽象プロパティを持つ）
    abstract class VectorBase
    {
        //　抽象プロパティ
        public abstract double X
        {
            set;
            get;
        }
        public abstract double Y
        {
            set;
            get;
        }
    }
}
