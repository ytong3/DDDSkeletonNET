using System.Reflection.Metadata.Ecma335;
using DDDSkeletonNET.Infrastructure.Common;

namespace DDDSkeleton.Portal.Domain.Address
{
    public class Address : ValueObjectBase
    {
        protected override void Validate()
        {
            if (string.IsNullOrEmpty(City))
            {
                AddBrokenRule(ValueObjectBusinessRule.CityInAddressRequired);
            }
        }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}