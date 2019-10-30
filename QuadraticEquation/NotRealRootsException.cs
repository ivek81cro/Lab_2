using System;

namespace QuadraticEquation
{
    
    class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException(string message) : base(message) => Console.WriteLine(message);
        public NotRealRootsException()
        {
            
        }
    }
}
