﻿using System.Data.SqlClient;

namespace CS26
{
    // 多重継承は禁止
    // 子：サブクラス（派生クラス)
    class A2 : A1 // ひとつのクラスだけを継承
    {
        // : base(10) でスーパークラスのコンストラクを設定
        public A2() : base(10)
        {
            // 派生クラスからはbase.で基底クラスの機能を使用
            base.protectedValue = 3;
        }
    }

    
}