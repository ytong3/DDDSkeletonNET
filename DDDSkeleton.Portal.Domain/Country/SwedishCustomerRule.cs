using System.Collections.Generic;
using DDDSkeleton.Portal.Domain.CountrySpecificCustomer;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Country
{
    public class SwedishCustomerRule : CountrySpecificCustomerRule
    {
        public override Country Country => CountryFactory.Create(CountryCodes.Sweden);
        public override List<BusinessRule> GetBrokenRules(CountrySpecificCustomer.CountrySpecificCustomer customer)
        {
            List<BusinessRule> brokenRules = new List<BusinessRule>();

            if (customer.Age < 18)
            {
                brokenRules.Add(new BusinessRule("Swedish customers must be at least 18"));
            }

            return brokenRules;
        }
    }
}