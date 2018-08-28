using System.Collections.Generic;
using DDDSkeleton.Portal.Domain.CountrySpecificCustomer;
using DDDSkeletonNET.Portal.Repository.Memroy.Database;
using DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork;

namespace DDDSkeletonNET.Portal.Repository.Memroy.Repositories
{
    public class CountrySpecificCustomerRepository : Repository<CountrySpecificCustomer, int, DatabaseCountrySpecificCustomer>, ICountrySpecificCustomerRepository
    {
        public CountrySpecificCustomerRepository(IUnitOfWork unitOfWork, IObjectContextFactory objectContextFactory) : base(unitOfWork, objectContextFactory)
        {
        }

        public override CountrySpecificCustomer FindBy(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CountrySpecificCustomer> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public override DatabaseCountrySpecificCustomer ConvertToDatabaseType(CountrySpecificCustomer domainType)
        {
            throw new System.NotImplementedException();
        }
    }
}