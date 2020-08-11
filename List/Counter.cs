using System.Data.SqlClient;

namespace CS30
{
    public class Counter
    {
        private List<int> _value = new List<int>();

        public int GetData(int index)
        {
            return _values[index];
        }

        public int GetData2(int index)
        {
            try
            {
                return _values[index];
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new MyException("マイエクセプション", ex);
            }
        }
    }
    
}