namespace DDDSkeletonNET.Portal.Repository.Memroy.Database
{
    public interface IObjectContextFactory
    {
        InMemoryDatabaseObjectContext Create();
    }
}