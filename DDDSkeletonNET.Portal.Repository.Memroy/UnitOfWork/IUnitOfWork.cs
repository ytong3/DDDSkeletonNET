using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterUpdate(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void RegisterInsertion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void RegisterDeletion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void Commit();
    }
}