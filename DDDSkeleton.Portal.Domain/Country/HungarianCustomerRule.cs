using System.Collections.Generic;
using DDDSkeleton.Portal.Domain.CountrySpecificCustomer;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Country
{
    public class HungarianCustomerRule : CountrySpecificCustomerRule
    {
        public override Country Country => CountryFactory.Create(CountryCodes.Hungary);

        public override List<BusinessRule> GetBrokenRules(CountrySpecificCustomer.CountrySpecificCustomer customer)
        {
            List<BusinessRule> brokenRules = new List<BusinessRule>();

            if (string.IsNullOrEmpty(customer.NickName))
            {
                brokenRules.Add(new BusinessRule("Hungarian customers must have a nickname"));
            }
            return brokenRules;
        }
    }
}