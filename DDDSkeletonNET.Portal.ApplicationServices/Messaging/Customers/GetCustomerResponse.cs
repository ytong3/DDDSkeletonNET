using DDDSkeletonNET.Portal.ApplicationServices.ViewModels;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class GetCustomerResponse : ServiceResponseBase
    {
        public CustomerViewModel Customer { get; set; }
    }
}