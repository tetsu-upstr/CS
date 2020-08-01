using System.Data.SqlClient;

namespace CS28
{
    // ポリモーフィズム　インターフェイス Iから始める命名
    interface IDatabase
    {
        void Save();
    }

    
}