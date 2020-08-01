using System;
using System.Data.SqlClient;

namespace CS28
{
    class Products : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの登録");
        }
    }
    
}