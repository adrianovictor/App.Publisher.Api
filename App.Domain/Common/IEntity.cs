namespace App.Domain.Common
{
    public interface IEntity<in TEntity> where TEntity : class
    {
        int Id { get; }

        bool IsPersisted();
    }
}
