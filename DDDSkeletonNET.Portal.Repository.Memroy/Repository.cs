using System;
using DDDSkeletonNET.Infrastructure.Common.Domain;
using DDDSkeletonNET.Portal.Repository.Memroy.Database;
using DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork;

namespace DDDSkeletonNET.Portal.Repository.Memroy
{
    public abstract class Repository<DomainType, IdType, DatabaseType>: IUnitOfWorkRepository where DomainType: IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IObjectContextFactory _objectContextFactory;

        public IObjectContextFactory ObjectContextFactory
        {
            get { return _objectContextFactory; }
        }

        public Repository(IUnitOfWork unitOfWork, IObjectContextFactory objectContextFactory)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("Unit of work");
            _objectContextFactory = objectContextFactory ?? throw new ArgumentNullException("Object context factory");
        }

        public abstract DomainType FindBy(IdType id);

        public void PersistInsertion(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            _objectContextFactory.Create().AddEntity<DatabaseType>(databaseType);
        }
        public void PersistUpdate(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            _objectContextFactory.Create().UpdateEntity<DatabaseType>(databaseType);
        }

        public void PersistDeletion(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            _objectContextFactory.Create().DeleteEntity<DatabaseType>(databaseType);
        }

        public void Update(DomainType aggregate)
        {
            _unitOfWork.RegisterUpdate(aggregate, this);
        }

        public void Insert(DomainType aggregate)
        {
            _unitOfWork.RegisterInsertion(aggregate, this);
        }

        public void Delete(DomainType aggregate)
        {
            _unitOfWork.RegisterDeletion(aggregate, this);
        }
        private DatabaseType RetrieveDatabaseTypeFrom(IAggregateRoot aggregateRoot)
        {
            DomainType domainType = (DomainType)aggregateRoot;
            DatabaseType databaseType = ConvertToDatabaseType(domainType);
            return databaseType;
        }
        public abstract DatabaseType ConvertToDatabaseType(DomainType domainType);

    }
}