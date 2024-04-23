using AutoMapper;
using DemoModule.Countries;
using DemoModule.Customers;

namespace DemoModule.Blazor;

public class DemoModuleBlazorAutoMapperProfile : Profile
{
    public DemoModuleBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<CustomerDto, CustomerCreateUpdateDto>();
        CreateMap<CountryDto, CountryCreateUpdateDto>();
    }
}
