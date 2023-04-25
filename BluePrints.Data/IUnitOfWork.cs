namespace BluePrints.Data
{
    internal interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}