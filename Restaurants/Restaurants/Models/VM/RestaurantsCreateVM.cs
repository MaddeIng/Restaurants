using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models.VM
{
    public class RestaurantsCreateVM
    {
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Du måste ange namn på restaurangen")]
        public string Name { get; set; }

        [Display(Name = "Typ av restaurang")]
        [Required(ErrorMessage = "Du måste ange restaurangtyp")]
        public string FoodType { get; set; }

        [Display(Name = "Land")]
        [Required(ErrorMessage = "Du måste ange i vilket land")]
        public string Country { get; set; }

        [Display(Name = "Stad")]
        [Required(ErrorMessage = "Du måste ange i vilken stad")]
        public string City { get; set; }

        [Display(Name = "Gata")]
        [Required(ErrorMessage = "Du måste ange gatuadress")]
        public string Street { get; set; }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Hemsida")]
        public string WebbPage { get; set; }

        [Display(Name = "Prisnivå")]
        [Required(ErrorMessage = "Du måste ange prisnivå")]
        public int PriceRange { get; set; }
    }
}
