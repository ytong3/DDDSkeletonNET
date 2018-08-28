using System.Collections.Generic;
using DDDSkeletonNET.Infrastructure.Common;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.CountrySpecificCustomer
{
    public class CountrySpecificCustomer : EntityBase<int>, IAggregateRoot
    {
        private Country.Country _country;

        public CountrySpecificCustomer(Country.Country country)
        {
            _country = country;
        }

        public string FirstName { get; set; }
        public int Age { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        protected override void Validate()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                AddBrokenRules(new BusinessRule("All custmers must have a first name"));
            }
            List<BusinessRule> brokenRules = new List<BusinessRule>();
            brokenRules.AddRange(CountrySpecificCustomerRuleFactory.Create(_country).GetBrokenRules(this));

            foreach (var brokenRule in brokenRules)
            {
                AddBrokenRules(brokenRule);
            }
        }

    }
}