using DDDSkeletonNET.Portal.ApplicationServices.Messaging.ViewModels;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class UpdateCustomerRequest : IntegerIdRequest
    {
        public UpdateCustomerRequest(int customerId) : base(customerId)
        { }

        public CustomerPropertiesViewModel CustomerProperties { get; set; }
    }
}