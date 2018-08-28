using DDDSkeleton.Portal.Domain.Address;
using DDDSkeletonNET.Infrastructure.Common;

namespace DDDSkeleton.Portal.Domain.Country
{
    public abstract class Country : ValueObjectBase
    {
        public abstract string CountryCode { get; }
        public abstract string CountryName { get; }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(CountryCode)) AddBrokenRule(ValueObjectBusinessRule.CountryCodeRequired);
            if (string.IsNullOrEmpty(CountryName)) AddBrokenRule(ValueObjectBusinessRule.CountryNameRequired);

        }
    }
}