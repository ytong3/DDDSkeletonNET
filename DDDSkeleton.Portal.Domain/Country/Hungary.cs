namespace DDDSkeleton.Portal.Domain.Country
{
    public class Hungary : Country
    {
        public override string CountryCode
        {
            get { return CountryCodes.Hungary; }
        }

        public override string CountryName
        {
            get { return "Hungary"; }
        }
    }
}