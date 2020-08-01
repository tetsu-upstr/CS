using System.Data.SqlClient;

namespace CS27
{
    class A1
    {
        // スーパークラス 親クラス（基底クラス)
        private int _privateValue;
        protected int protectedValue;

        // コンストラクタ
        public A1(int value)
        {
            _privateValue = value;
        }

        // 基底クラス　virtual で オーバーライドしてもいいよのサイン
        public virtual int GetData()
        {
            return 1;
        }
    }

    
}