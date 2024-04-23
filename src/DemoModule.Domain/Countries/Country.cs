using System;
using Volo.Abp.Domain.Entities;

namespace DemoModule.Countries
{
    public class Country : Entity<Guid>
    {
        public string Name { get; set; } = default!;
    }
}