namespace DDDSkeletonNET.Portal.Repository.Memroy.Database
{
    public class LazySingletonObjectContextFactory : IObjectContextFactory
    {
        public InMemoryDatabaseObjectContext Create()
        {
            return InMemoryDatabaseObjectContext.Instance;
        }
    }
}