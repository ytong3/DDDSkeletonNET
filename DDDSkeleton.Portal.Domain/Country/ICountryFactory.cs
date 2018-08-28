namespace DDDSkeleton.Portal.Domain.Country
{
    public interface ICountryFactory
    {
        Country CreateCountry(string countryCode);
    }
}