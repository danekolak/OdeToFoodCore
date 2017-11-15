using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using System.Linq;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IPeopleData _peopleData;
        private ICharseData _charseData;

        public HomeController(IRestaurantData restaurantData, IPeopleData peopleData, ICharseData charseData)
        {
            _restaurantData = restaurantData;
            _peopleData = peopleData;
            _charseData = charseData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll().Where(r => r.Name == "Tersiguels" && r.Name == "King's Contrivance")
                .Concat(_charseData.GetAllChars()).Where(c => c.CharsName == "Chars 6")
                .Concat(_peopleData.GetAllPeople()).OrderByDescending(i => i.Id);

            return View(model);
        }
        public IActionResult NumbersOfChar()
        {
            var model = _charseData.GetAllChars().Where(r => r.Id == 3);
            return View(model);
        }

    }
}
