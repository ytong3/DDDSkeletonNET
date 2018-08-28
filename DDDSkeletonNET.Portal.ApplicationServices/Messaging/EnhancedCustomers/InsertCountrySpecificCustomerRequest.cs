namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.EnhancedCustomers
{
    public class InsertCountrySpecificCustomerRequest : ServiceRequestBase
    {
        public CountrySpecificCustomerViewModel CountrySpecificCustomer { get; set; }
    }
}