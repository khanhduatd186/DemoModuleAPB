using AutoMapper;
using DemoModule.Customers;
using DemoModule.Countries;

namespace DemoModule;

public class DemoModuleApplicationAutoMapperProfile : Profile
{
    public DemoModuleApplicationAutoMapperProfile()
    {
        CreateMap<Country, CountryDto>();
        CreateMap<CountryCreateUpdateDto, Country>();

        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerCreateUpdateDto, Customer>();
    }
}
