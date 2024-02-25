using ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects;
using ATLASWepAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using ProcessorLibrary.DataProcessor.Interface.Caching;

namespace ATLASWepAPI.DataAccessLayer.Implementation.DataAccessObjects
{
    public class OrderItemDAO : IDataAccessObject<OrderItem>
    {
        private readonly ATLASDbContext _context;
        private readonly IDataCacheProcessor _dataCacheProcessor;

        private readonly string OrderItemsCacheKey = "OrderItems";

        public OrderItemDAO(ATLASDbContext context,
                            IDataCacheProcessor dataCacheProcessor) 
        { 
            _context = context;
            _dataCacheProcessor = dataCacheProcessor;

            _dataCacheProcessor.RegisterType<List<OrderItem>>(OrderItemsCacheKey);
        }

        public Task<bool> CreateEntities(List<OrderItem> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateEntity(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntities(List<OrderItem> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntity(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderItem>> ReadEntities()
        {
            if (await _dataCacheProcessor.ExistsAsync(OrderItemsCacheKey))
            {
                return await _dataCacheProcessor.GetAsync<List<OrderItem>>(OrderItemsCacheKey);
            }

            List<OrderItem> OrderItems = await _context.OrderItems.ToListAsync();
            await _dataCacheProcessor.SetAsync(OrderItemsCacheKey, OrderItems);

            return OrderItems;
        }

        public Task<OrderItem> ReadEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntities(List<OrderItem> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntity(OrderItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
