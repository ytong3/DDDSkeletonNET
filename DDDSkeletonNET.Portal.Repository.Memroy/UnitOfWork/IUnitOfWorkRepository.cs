using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        void PersistInsertion(IAggregateRoot aggregateRoot);
        void PersistUpdate(IAggregateRoot aggregateRoot);
        void PersistDeletion(IAggregateRoot aggregateRoot);
    }
}