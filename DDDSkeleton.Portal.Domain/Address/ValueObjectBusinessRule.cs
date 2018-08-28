using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Address
{
    public static class ValueObjectBusinessRule
    {
        public static readonly BusinessRule CityInAddressRequired = new BusinessRule("An Address must have a city");
        public static readonly BusinessRule CountryCodeRequired = new BusinessRule("Country must have a country code");
        public static readonly BusinessRule CountryNameRequired = new BusinessRule("Country must have a name");
    }
}