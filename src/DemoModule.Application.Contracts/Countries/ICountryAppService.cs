using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace DemoModule.Countries;

    public interface ICountryAppService : ICrudAppService<
         CountryDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CountryCreateUpdateDto>
    {
    }