using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public class InMemoryCharsData : ICharseData
    {
        public InMemoryCharsData()
        {
            _chars = new List<Restaurant>
            {
                new Restaurant { Id =1, CharsName= "Chars 1"},
                new Restaurant { Id =2, CharsName= "Chars 2"},
                new Restaurant { Id =3, CharsName= "Chars 3"},
                new Restaurant { Id =4, CharsName= "Chars 4"},
                new Restaurant { Id =5, CharsName= "Chars 5"},
                new Restaurant { Id =6, CharsName= "Chars 6"},
                new Restaurant { Id =7, CharsName= "Chars 7"},
                new Restaurant { Id =8, CharsName= "Chars 8"}
            };
        }

        List<Restaurant> _chars;

        public IEnumerable<Restaurant> GetAllChars() => _chars;

    }
}
