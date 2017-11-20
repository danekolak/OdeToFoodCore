using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System.Linq;

namespace OdeToFood.Controllers
{

    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IPeopleData _peopleData;
        private ICharseData _charseData;
        private IGreeter _greeter;

        public HomeController(IGreeter greeter, IRestaurantData restaurantData, IPeopleData peopleData, ICharseData charseData)
        {
            _restaurantData = restaurantData;
            _peopleData = peopleData;
            _charseData = charseData;
            _greeter = greeter;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null) return RedirectToAction(nameof(Index));

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid)
            {


                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = _restaurantData.Add(newRestaurant);


                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
            }
            else
            {
                return View();
            }
        }








        public IActionResult NumbersOfChar()
        {
            var model = _restaurantData.GetAll().Where(r => r.Name == "Tersiguels")
                .Concat(_charseData.GetAllChars()).Where(c => c.CharsName == "Chars 6")
                .Concat(_peopleData.GetAllPeople()).OrderByDescending(i => i.Id);
            return View(model);
        }

    }
}
