using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace DDDSkeleton.Portal.Domain.Country
{
    public class CountryFactory
    {
        private static IEnumerable<Country> AllCountries()
        {
            return new List<Country>()
            {
                new Hungary(),
                new Gemany(),
                new Sweden()
            };
        }

        public static Country Create(string countryCode)
        {
            return (from c in AllCountries() where c.CountryCode.ToLower() == countryCode.ToLower() select c).FirstOrDefault();
        }
    }
}