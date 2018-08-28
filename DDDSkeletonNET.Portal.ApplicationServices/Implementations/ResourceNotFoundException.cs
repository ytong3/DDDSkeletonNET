using System;

namespace DDDSkeletonNET.Portal.ApplicationServices.Implementations
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string message)
            : base(message)
        { }

        public ResourceNotFoundException()
            : base("The requested resource was not found.")
        { }
    }
}