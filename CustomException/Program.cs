using System;
namespace CustomExceptionHandling
{
    //Creating our own Exception Class by inheriting Exception class
    public class EvenNumberException : Exception
    {
        public EvenNumberException()
        {
        }
        public EvenNumberException(string message)
            : base(message)
        {
        }
        public EvenNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
      
       
    }
}