namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class DeleteCustomerRequest : IntegerIdRequest
    {
        public DeleteCustomerRequest(int customerId) : base(customerId)
        { }
    }
}