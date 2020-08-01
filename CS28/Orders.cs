using System;

namespace CS28
{
    public class Orders : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("発注テーブル登録");
        }
    }
}
