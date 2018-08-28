using System.Collections.Generic;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.CountrySpecificCustomer
{
    public abstract class CountrySpecificCustomerRule
    {
        public abstract Country.Country Country { get; }
        public abstract List<BusinessRule> GetBrokenRules(CountrySpecificCustomer customer);
    }


}