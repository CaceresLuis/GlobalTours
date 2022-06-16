using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Place, PlaceDto>()
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom<PlaceUrlResolver>())
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
