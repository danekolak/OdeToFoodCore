using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CharsName { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
