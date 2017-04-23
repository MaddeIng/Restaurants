using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models.VM
{
    public class RestaurantsInfoVM
    {
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Typ av restaurang")]
        public string FoodType { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "Stad")]
        public string City { get; set; }

        [Display(Name = "Gata")]
        public string Street { get; set; }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Hemsida")]
        public string WebbPage { get; set; }

        [Display(Name = "Prisnivå")]
        public int PriceRange { get; set; }
    }
}
