using System.Collections.Generic;
using DDDSkeletonNET.Portal.ApplicationServices.ViewModels;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class GetCustomersResponse : ServiceResponseBase
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }
    }
}