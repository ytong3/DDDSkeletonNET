namespace DDDSkeleton.Portal.Domain.Country
{
    public class Sweden : Country
    {
        public override string CountryCode
        {
            get { return CountryCodes.Sweden; }
        }

        public override string CountryName
        {
            get { return "Sweden"; }
        }
    }
}