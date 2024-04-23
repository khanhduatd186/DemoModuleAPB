using DemoModule.Countries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace DemoModule.Customers;
public interface ICustomerAppService : ICrudAppService<
        CustomerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CustomerCreateUpdateDto>
{
    Task<ListResultDto<CountryDto>> GetCountryLookupAsync();
}
