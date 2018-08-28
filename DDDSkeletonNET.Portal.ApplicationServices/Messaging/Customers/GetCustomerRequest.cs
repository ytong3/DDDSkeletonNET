namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class GetCustomerRequest : IntegerIdRequest
    {
        public GetCustomerRequest(int customerId) : base(customerId)
        { }
    }
}