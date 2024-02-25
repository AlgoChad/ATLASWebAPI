using ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects;
using ATLASWepAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using ProcessorLibrary.DataProcessor.Interface.Caching;

namespace ATLASWepAPI.DataAccessLayer.Implementation.DataAccessObjects
{
    public class OrderDAO : IDataAccessObject<Order>
    {
        private readonly ATLASDbContext _context;
        private readonly IDataCacheProcessor _dataCacheProcessor;

        private readonly string OrderCacheKey = "OrderCache";
        public OrderDAO(ATLASDbContext context,
                        IDataCacheProcessor dataCacheProcessor) 
        {
            _context = context;
            _dataCacheProcessor = dataCacheProcessor;


            _dataCacheProcessor.RegisterType<List<Order>>(OrderCacheKey);
        }

        public Task<bool> CreateEntities(List<Order> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateEntity(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntities(List<Order> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntity(Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> ReadEntities()
        {
            if (await _dataCacheProcessor.ExistsAsync(OrderCacheKey))
            {
                return await _dataCacheProcessor.GetAsync<List<Order>>(OrderCacheKey);
            }

            List<Order> Orders = await _context.Orders.ToListAsync();
            await _dataCacheProcessor.SetAsync(OrderCacheKey, Orders);

            return Orders;
        }

        public Task<Order> ReadEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntities(List<Order> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntity(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
