using System.Data.SqlClient;

namespace CS24
{

    public class Database : IDisposable
    {
        // 全体で使いたい時
        private SqlDataAdapter _adapter = new SqlDataAdapter();
        public Database()
        {
        
        }

        public void Insert()
        {
            // SqlConnection connection = new SqlConnection();

            // try
            // {
            //     // 処理
            // }
            // catch(Exception ex)
            // {

            // }
            // finally // finlallyを宣言すると最後に必ず通る
            // {
            //     // Dispose リソースの開放宣言
            //     connection.Dispose();
            // }

            // usingを使うDisposeの方法
            using (SqlConnection connection = new SqlConnection())
            using (SqlCommand command = new SqlCommand("select * from xxx", connection))
            {
                // 処理
            }
        }

        public void Cancel()
        {
            _adapter.SelectCommand.Cancel();
        }

        public void Dispose()
        {
            throw new NotImplementException();
        }

    }

}