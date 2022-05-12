﻿using System;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();　//　一つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();　//　二つ目のPersonクラスのメソッドのインスタンスを生成
            p1.name = "山田太郎";　//　フィールドnameに値を代入
            p1.age = 19; //　フィールドageに値を代入
            p2.SetAgeAndName("佐藤花子", 23);　//SetAgeAndName()メソッドで、nameとageを設定
            //　ShowAgeAndName()メソッドで、それぞれのインスタンスのnameとageを表示
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
