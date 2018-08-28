using System;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging
{
    public abstract class ServiceResponseBase
    {
        public ServiceResponseBase()
        {
            this.Exception = null;
        }

        public Exception Exception { get; set; }
    }
}