using System;

namespace CS20
{
    public class Class1
    {
        // フィールドの書き方 アクセス修飾子 型 変数名（小文字）
        private int _count = 0;

        // public 外部からも参照可能
        public void Call()
        {
            int _count = 0;

            _count++; // _をつけて、関数内部で宣言したものか、privateで宣言したものかを判別するのもあり
        }
    }
}