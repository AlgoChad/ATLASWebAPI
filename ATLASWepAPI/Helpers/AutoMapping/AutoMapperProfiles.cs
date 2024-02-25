using ATLASWepAPI.Models.DataTransferObjects;
using ATLASWepAPI.Models.Entities;
using AutoMapper;

namespace ATLASWepAPI.Helpers.AutoMapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<OrderItem, OrderDTO.OrderItem>().ReverseMap();
            CreateMap<OrderNote, OrderDTO.OrderNote>().ReverseMap();
        }
    }
}
