using System;
namespace SampleEx303
{
    //　子クラス
    public class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFoo()メソッド");
        }
    }
}
