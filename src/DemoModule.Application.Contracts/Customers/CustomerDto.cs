using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace DemoModule.Customers
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string Name { get; set; } = default!;

        public string CountryName { get; set; } = default!;
    }
}
