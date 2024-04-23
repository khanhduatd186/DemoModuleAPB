using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoModule.Customers
{
    public class CustomerCreateUpdateDto
    {
        [Required]
        public string Name { get; set; }

        public Guid? CountryId { get; set; }
    }
}
