using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface ICharseData
    {
        IEnumerable<Restaurant> GetAllChars();
    }
}
