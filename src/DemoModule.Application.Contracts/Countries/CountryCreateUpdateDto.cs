using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoModule.Countries
{
    public class CountryCreateUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
