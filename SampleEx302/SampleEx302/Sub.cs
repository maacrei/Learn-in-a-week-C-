using System;
namespace SampleEx302
{
    //　サブクラス（Superクラスを継承）
    public class Sub : Super
    {
        //　subクラスのコンストラクタ
        public Sub()
        {
            Console.WriteLine("Subのコンストラクタ(引数なし)");
        }
        //　Subクラスのコンストラクタ
        public Sub(int param) : base(param)
        {
            Console.WriteLine("Subのコンストラクタ(引数:param={0}) ", param);
        }
        //　Subクラスのデストラクタ
        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}
