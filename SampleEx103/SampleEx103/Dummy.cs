using System;
namespace SampleEx103
{
    public class Dummy
    {
        //　コンストラクタ
        public Dummy()
        {
            Console.WriteLine("コンストラクタ");
        }
        //　デストラクタ
        ~Dummy()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
