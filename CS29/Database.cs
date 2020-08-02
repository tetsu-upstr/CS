using System.Data.SqlClient;

namespace CS29
{
    // 抽象クラス ロジックも書ける
    public abstract class Database
    {
        public void Save()
        {
            // 一文だけ処理を派生クラスに委ねるという使い方ができる

            try
            {
                Transaction();
                
                SaveMethod();

                Commit();
            }
            catch
            {
                RollBack();
            }
        }

        // 例えばsave処理だけテーブルごとに変えたい場合、下記のように定義だけ指定
        protected abstract void SaveMethod();

        private void Transaction()
        { }

        private void Commit()
        { }

        private void RollBack()
        { }
        public void Save()
        {
            Console.WriteLine("商品マスタの登録");
        }
    }

    
}