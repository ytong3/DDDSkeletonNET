using System.Collections.Generic;
using DDDSkeleton.Portal.Domain.CountrySpecificCustomer;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Country
{
    public class GermanCustomerRule : CountrySpecificCustomerRule
    {
        public override Country Country => CountryFactory.Create(CountryCodes.Germany);

        public override List<BusinessRule> GetBrokenRules(CountrySpecificCustomer.CountrySpecificCustomer customer)
        {
            List<BusinessRule> brokenRules = new List<BusinessRule>();

            if (string.IsNullOrEmpty(customer.Email)){
                brokenRules.Add(new BusinessRule("German Customers must have an email address."));
            }
            return brokenRules;
        }
    }
}