using DDDSkeletonNET.Portal.ApplicationServices.Messaging.ViewModels;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class InsertCustomerRequest : ServiceRequestBase
    {
        public CustomerPropertiesViewModel CustomerProperties { get; set; }
    }
}