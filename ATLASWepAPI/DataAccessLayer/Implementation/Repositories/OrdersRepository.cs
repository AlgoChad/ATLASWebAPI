using ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects;
using ATLASWepAPI.DataAccessLayer.Interface.Repositories;
using ATLASWepAPI.Models.DataTransferObjects;
using ATLASWepAPI.Models.Entities;
using AutoMapper;
using ProcessorLibrary.DataProcessor.Interface.Caching;
using System.Collections.Concurrent;

namespace ATLASWepAPI.DataAccessLayer.Implementation.Repositories
{
    public class OrdersRepository : IRepository<OrderDTO>
    {
        private readonly IDataAccessObject<Order> _orderDao;
        private readonly IDataAccessObject<OrderNote> _orderNoteDao;
        private readonly IDataAccessObject<OrderItem> _orderItemDao;

        private readonly IDataCacheProcessor _dataCacheProcessor;

        private readonly IMapper _mapper;

        private readonly string OrderDTOCacheKey = "OrderDTOS";
        public OrdersRepository(IDataAccessObject<Order> orderDao,
                                IDataAccessObject<OrderNote> orderNoteDao,
                                IDataAccessObject<OrderItem> orderItemDao,
                                IMapper mapper,
                                IDataCacheProcessor dataCacheProcessor) 
        { 
            _orderDao = orderDao;
            _orderNoteDao = orderNoteDao;
            _orderItemDao = orderItemDao;
            _mapper = mapper;
            _dataCacheProcessor = dataCacheProcessor;

            _dataCacheProcessor.RegisterType<List<OrderDTO>>(OrderDTOCacheKey);
        }

        public Task<bool> AddItemAsync(OrderDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDTO>> GetItemsAsync()
        {
            if (await _dataCacheProcessor.ExistsAsync(OrderDTOCacheKey))
            {
                return await _dataCacheProcessor.GetAsync<List<OrderDTO>>(OrderDTOCacheKey);
            }

            var orders = await _orderDao.ReadEntities();
            var orderNotes = await _orderNoteDao.ReadEntities();
            var orderItems = await _orderItemDao.ReadEntities();

            var orderItemsDTO = _mapper.Map<List<OrderDTO.OrderItem>>(orderItems);
            var orderNotesDTO = _mapper.Map<List<OrderDTO.OrderNote>>(orderNotes);

            List<OrderDTO> Orders = new List<OrderDTO>();

            foreach (var item in orders)
            {
                var orderObject = new OrderDTO
                {
                    Id = item.Id,
                    CustomOrderNumber = item.CustomOrderNumber,
                    OrderItems = orderItemsDTO.Where(x => x.OrderId == item.Id).ToList(),
                    OrderNotes = orderNotesDTO.Where(x => x.OrderId == item.Id).ToList()
                };

                Orders.Add(orderObject);
            }

            await _dataCacheProcessor.SetAsync(OrderDTOCacheKey, Orders);

            return Orders.ToList();
        }

        public Task<bool> UpdateItemAsync()
        {
            throw new NotImplementedException();
        }
    }
}
