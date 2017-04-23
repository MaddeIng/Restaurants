using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models.VM
{
    public class RestaurantsIndexVM
    {
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Prisnivå")]
        public int PriceRange { get; set; }

        [Display(Name = "Hemsida")]
        public string WebbPage { get; set; }
    }
}
