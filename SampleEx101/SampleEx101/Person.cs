﻿using System;
namespace SampleEx101
{
    public class Person
    {
        //　フィールドname(名前)
        private string name = "";
        //　フィールドage(年齢)
        private int age = 0;
        //　コンストラクタ(引数なし)
        public Person() : this("名無し", 0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        //　コンストラクタ(引数あり)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}", name, age);
        }
        //　情報の表示
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前: {0} 年齢: {1}", name, age);
        }
        //　nameのプロパティ
        public string Name
        {
            set; get;
        }
        //　ageのプロパティ
        public int Age
        {
            set; get;
        }
    }
}
