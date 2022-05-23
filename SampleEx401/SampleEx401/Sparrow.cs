using System;
namespace SampleEx401
{
    //　すずめクラス
    public class Sparrow
    {
        private String name = "すずめ";
        //　すずめが鳴く
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        //　名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
