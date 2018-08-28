using DDDSkeletonNET.Portal.ApplicationServices.Messaging.EnhancedCustomers;

namespace DDDSkeletonNET.Portal.ApplicationServices.Interfaces
{
    public interface ICountrySpecificCustomerService
    {
        InsertCountrySpecificCustomerResponse InsertCountrySpecificCustomer(InsertCountrySpecificCustomerRequest request);
    }
}