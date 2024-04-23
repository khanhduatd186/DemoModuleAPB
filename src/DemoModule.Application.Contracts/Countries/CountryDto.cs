using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace DemoModule.Countries
{
    public class CountryDto : EntityDto<Guid>
    {
        public string Name { get; set; } = default!;
    }
}
