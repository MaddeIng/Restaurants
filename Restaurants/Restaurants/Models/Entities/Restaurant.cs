using System;
using System.Collections.Generic;

namespace Restaurants.Models.Entities
{
    public partial class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FoodType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebbPage { get; set; }
        public int PriceRange { get; set; }
    }
}
