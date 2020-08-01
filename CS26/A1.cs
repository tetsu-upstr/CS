using System.Data.SqlClient;

namespace CS26
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

        public int GetData()
        {
            return 1;
        }
    }

    
}