using System.Data.SqlClient;

namespace CS25
{
    internal class Counter
    {
        // 静的メンバー
        // クラス、変数にstaticをつける
        // クラス単位で生成 = アプリケーションにただ一つ
        private static int _count = 0;
        private int _value = 0;

        // 静的メソッド
        internal static void Call()
        {
            // 処理の中で使えるのは静的メンバーのみ
            _count++;
            // sitaticじゃない変数は呼び出せない
        }

        // new せずにそのまま呼び出せる
        // Windows formなどで Counter.Call()として使用する

        internal static int GetCount()
        {
            return _count;
        }
    }

    
}