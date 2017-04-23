using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models.Entities;
using Restaurants.Models.VM;

namespace Restaurants.Controllers
{
    public class RestaurantsController : Controller
    {
        RestaurantsContext context;
        public RestaurantsController(RestaurantsContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var restaurants = await context.ListRestaurantsAsync();
            return View(restaurants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantsCreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            else
                context.AddRestaurant(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
