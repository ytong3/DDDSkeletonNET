using System.Collections.Generic;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Country
{
    public abstract class CountrySpecificCustomerRule
    {
        public abstract Country Country { get; }
        public abstract List<BusinessRule> GetBrokenRules(CountrySpecificCustomer customer);
    }


}