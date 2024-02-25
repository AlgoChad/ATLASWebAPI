namespace ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects
{
    public interface IDataAccessObject<TEntity>
    {
        Task<TEntity> ReadEntity(int id);
        Task<List<TEntity>> ReadEntities();
        Task<bool> CreateEntity(TEntity entity);
        Task<bool> CreateEntities(List<TEntity> entities);
        Task<bool> UpdateEntity(TEntity entity);
        Task<bool> UpdateEntities(List<TEntity> entities);
        Task<bool> DeleteEntity(TEntity entity);
        Task<bool> DeleteEntities(List<TEntity> entities);
    }
}
