using AutoMapper;
using ChainOfResponsability.Application.DTOs.Item;
using ChainOfResponsability.Application.DTOs.Order;
using ChainOfResponsability.Application.DTOs.OrderItem;
using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ItemDto, Item>().ReverseMap();
            CreateMap<OrderItemDto, OrderItem>();
        }
    }
}
