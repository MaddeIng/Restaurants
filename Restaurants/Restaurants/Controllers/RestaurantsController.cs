using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models.Entities;
using Restaurants.Models.VM;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var model = new RestaurantsCreateVM();
            model.FoodTypeItems = new SelectListItem[]
            {
                new SelectListItem { Text = "Asiatiskt", Value = "1"},
                new SelectListItem { Text = "Mellanöstern", Value = "2"},
                new SelectListItem { Text = "Afrikanskt", Value = "3"},
                new SelectListItem { Text = "Medelhav", Value = "4"},
                new SelectListItem { Text = "Sydamerikanskt", Value = "5"},
                new SelectListItem { Text = "Amerikanskt", Value = "6"},
                new SelectListItem { Text = "Europeiskt", Value = "7"},
            };
            return View(model);
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

        public IActionResult GetPartialView(string id)
        {
            var viewModel = context.GetRestaurantsViewModel(id);

            return PartialView("_RestaurantList1", viewModel);
        }
    }
}
