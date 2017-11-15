using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface IPeopleData
    {
        IEnumerable<Restaurant> GetAllPeople();
    }
}
