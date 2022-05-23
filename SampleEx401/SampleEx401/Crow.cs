using System;
namespace SampleEx401
{
    //　カラスクラス
    public class Crow
    {
        private String name = "カラス";
        //　カラスが鳴く
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        //　名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
