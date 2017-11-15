using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public class InMemoryPeopleData : IPeopleData
    {

        public InMemoryPeopleData()
        {
            _people = new List<Restaurant>
            {
                new Restaurant { Id = 1, FirstName ="Johny",LastName ="Cash"},
                new Restaurant { Id = 2, FirstName = "John", LastName="Smith"},
                new Restaurant { Id = 3, FirstName = "Maria", LastName="Jovovich"},
                new Restaurant { Id = 4, FirstName = "Steve", LastName="Stevens"},
            };
        }
        List<Restaurant> _people;

        public IEnumerable<Restaurant> GetAllPeople() => _people;

    }
}
