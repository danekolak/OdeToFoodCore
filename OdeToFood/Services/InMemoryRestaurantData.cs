using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id=1, Name="Scott's Pizza Places"},
                new Restaurant { Id=2, Name="Tersiguels"},
                new Restaurant { Id=3, Name="King's Contrivance"},
            };
        }
        List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll() => _restaurants;













    }
}
