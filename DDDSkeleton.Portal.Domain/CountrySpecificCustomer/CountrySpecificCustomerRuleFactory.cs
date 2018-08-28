using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DDDSkeleton.Portal.Domain.Country;

namespace DDDSkeleton.Portal.Domain.CountrySpecificCustomer
{
    public class CountrySpecificCustomerRuleFactory
    {
        private static IEnumerable<CountrySpecificCustomerRule> GetAllCountryRules()
        {
            List<CountrySpecificCustomerRule> implementingRules = new List<CountrySpecificCustomerRule>()
            {
                new HungarianCustomerRule(),
                new SwedishCustomerRule(),
                new GermanCustomerRule()
            };
            return implementingRules;
        }

        public static CountrySpecificCustomerRule Create(Country.Country country)
        {
            return (from c in GetAllCountryRules() where c.Country.CountryCode == country.CountryCode select c)
                .FirstOrDefault();
        }
    }
}