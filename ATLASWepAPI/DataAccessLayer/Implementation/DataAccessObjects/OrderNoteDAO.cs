using ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects;
using ATLASWepAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using ProcessorLibrary.DataProcessor.Interface.Caching;

namespace ATLASWepAPI.DataAccessLayer.Implementation.DataAccessObjects
{
    public class OrderNoteDAO : IDataAccessObject<OrderNote>
    {
        private readonly ATLASDbContext _context;
        private readonly IDataCacheProcessor _dataCacheProcessor;

        private readonly string OrderNotesCacheKey = "OrderNotesCache";
        public OrderNoteDAO(ATLASDbContext context,
                            IDataCacheProcessor dataCacheProcessor)
        {
            _context = context;
            _dataCacheProcessor = dataCacheProcessor;

            _dataCacheProcessor.RegisterType<List<OrderNote>>(OrderNotesCacheKey);
        }
        public Task<bool> CreateEntities(List<OrderNote> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateEntity(OrderNote entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntities(List<OrderNote> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntity(OrderNote entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderNote>> ReadEntities()
        {
            if (await _dataCacheProcessor.ExistsAsync(OrderNotesCacheKey))
            {
                return await _dataCacheProcessor.GetAsync<List<OrderNote>>(OrderNotesCacheKey);
            }

            List<OrderNote> OrderNotes = await _context.OrderNotes.ToListAsync();
            await _dataCacheProcessor.SetAsync(OrderNotesCacheKey, OrderNotes);

            return await _context.OrderNotes.ToListAsync();
        }

        public Task<OrderNote> ReadEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntities(List<OrderNote> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntity(OrderNote entity)
        {
            throw new NotImplementedException();
        }
    }
}
