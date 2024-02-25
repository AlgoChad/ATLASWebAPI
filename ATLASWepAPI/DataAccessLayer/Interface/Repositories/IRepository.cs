namespace ATLASWepAPI.DataAccessLayer.Interface.Repositories
{
    public interface IRepository<TDataObject>
    {
        Task<TDataObject> GetItemAsync(int id);
        Task<List<TDataObject>> GetItemsAsync();
        Task<bool> UpdateItemAsync();
        Task<bool> AddItemAsync(TDataObject item);
        Task<bool> DeleteItemAsync(int id);
    }
}
