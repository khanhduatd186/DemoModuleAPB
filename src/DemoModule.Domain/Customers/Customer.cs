using System;
using Volo.Abp.Domain.Entities;

namespace DemoModule.Customers
{
    public class Customer : Entity<Guid>
    {
        public Guid? CountryId { get; set; }

        public string Name { get; set; } = default!;
    }
}