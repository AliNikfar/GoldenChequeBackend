using AutoMapper;
using GoldenChequeBackEnd.Domain.Entities;
using GoldenChequeBackEnd.Infrastructure.ViewModel;

namespace GoldenChequeBackEnd.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
