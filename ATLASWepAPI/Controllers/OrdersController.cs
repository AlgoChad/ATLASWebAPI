using ATLASWepAPI.DataAccessLayer.Interface.Repositories;
using ATLASWepAPI.Models.DataTransferObjects;
using ATLASWepAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATLASWepAPI.Controllers
{
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IRepository<OrderDTO> _ordersRepository;
        public OrdersController(IRepository<OrderDTO> ordersRepository) 
        { 
            _ordersRepository = ordersRepository;
        }
        [HttpGet]
        [Route("GetAllOrders")]
        public async Task<IActionResult> GetAllOrderAsync()
        {
            return Json(new { Orders = await _ordersRepository.GetItemsAsync() });
        }
    }
}
