using System;

namespace CS30
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
