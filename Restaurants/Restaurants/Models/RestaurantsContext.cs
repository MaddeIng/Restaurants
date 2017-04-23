using Microsoft.EntityFrameworkCore;
using Restaurants.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models.Entities
{
    public partial class RestaurantsContext
    {
        public RestaurantsContext(DbContextOptions<RestaurantsContext> options) : base (options)
        {
        }

        public void AddRestaurant(RestaurantsCreateVM viewModel)
        {
            var restaurant = new Restaurant();

            restaurant.Name = viewModel.Name;
            restaurant.FoodType = viewModel.FoodType;
            restaurant.Country = viewModel.Country;
            restaurant.City = viewModel.City;
            restaurant.Street = viewModel.Street;
            restaurant.PhoneNumber = viewModel.PhoneNumber;
            restaurant.Email = viewModel.Email;
            restaurant.WebbPage = viewModel.WebbPage;
            restaurant.PriceRange = viewModel.PriceRange;

            Restaurant.Add(restaurant);
            this.SaveChanges();
        }

        public async Task<RestaurantsIndexVM[]> ListRestaurantsAsync()
        {
            return await Restaurant
                .Select(r => new RestaurantsIndexVM
                {
                    Name = r.Name,
                    WebbPage = r.WebbPage,
                    PriceRange = r.PriceRange
                }).ToArrayAsync();
        }

        public string DisplayValue(int priceRange)
        {
            if (priceRange <= 150 || priceRange >= 0)
            {
                return $"$";
            }
            else if (priceRange <= 250)
            {
                return $"$$";
            }
            else
            {
                return $"$$$";
            }
        }

        public string DisplayColor(int priceRange)
        {
            if (priceRange <= 150 || priceRange >= 0)
            {
                return "green";
            }
            else if (priceRange <= 250)
            {
                return "orange";
            }
            else
            {
                return "red";
            }
        }

        public async Task<RestaurantsInfoVM[]> ListRestaurantsInfoAsync()
        {
            return await Restaurant
                .Select(r => new RestaurantsInfoVM
                {
                    Name = r.Name,
                    FoodType = r.FoodType,
                    Country = r.Country,
                    City = r.City,
                    Street = r.Street,
                    PhoneNumber = r.PhoneNumber,
                    Email = r.Email,
                    WebbPage = r.WebbPage,
                    PriceRange = r.PriceRange
                }).ToArrayAsync();
        }
    }
}
