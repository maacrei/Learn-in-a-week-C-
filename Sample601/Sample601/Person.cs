using System;
namespace Sample601
{
    public class Person
    {
        //　名前（フィールド）
        public string name = "";
        //　年齢（フィールド）
        public int age = 0;
        //　情報の表示（メソッド）「void」戻り値を返さない場合につける,（）内は引数
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前: {0} 年齢: {1}", name, age);
        }
        //　情報の設定　（）内は引数
        public void SetAgeAndName(string name, int age)
        {
            //thisは自分自身のインスタンスという意味
            this.name = name;
            this.age = age;
        }
    }
}
