using System;

namespace CS23
{
    public class Counter
    {
        // フィールド　（書き方）アクセス修飾子 型 変数名（小文字）
        private int _count = 0;

        // コンストラクタ
        public Counter(int count)
        {
            _count = count;
        }

        // プロパティ　フィールドとコンストラクの下に書くのが慣習
        public int Count
        {
            get
            {
                return _count;
            }
            
            set
            {
                if (value > 100)
                {
                    _count = 0;
                    return;
                }

                _count = value;
            }
        }

        public void Call()
        {
            _count++;
        }

        // public void SetCount(int value)
        // {
        //     if (value > 100)
        //     {
        //         _count = 0;
        //         return;
        //     }

        //     _count = value;
        // }

        // public int GetCount()
        // {
        //     return _count;
        // }
    }
}