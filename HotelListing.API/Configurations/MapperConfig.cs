using AutoMapper;
using HotelListing.API.Data;
using Microsoft.Build.Framework.Profiler;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
        }
    }
}
