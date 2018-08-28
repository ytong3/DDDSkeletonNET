using System;

namespace DDDSkeletonNET.Infrastructure.Common
{
    public class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string message):base(message)
        {
            
        }
        
    }
}