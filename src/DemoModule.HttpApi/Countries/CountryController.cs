using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp;

namespace DemoModule.Countries
{
    [RemoteService(Name = DemoModuleRemoteServiceConsts.RemoteServiceName)]
    [Route("/api/customer-management/country")]
    public class CountryController : DemoModuleController, ICountryAppService
    {
        private readonly ICountryAppService _service;

        public CountryController(ICountryAppService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public virtual Task<CountryDto> CreateAsync(CountryCreateUpdateDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<CountryDto> UpdateAsync(Guid id, CountryCreateUpdateDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<CountryDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        [Route("")]
        public virtual Task<PagedResultDto<CountryDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _service.GetListAsync(input);
        }
    }
}
