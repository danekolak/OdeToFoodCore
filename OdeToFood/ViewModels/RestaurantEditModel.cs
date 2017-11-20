﻿using OdeToFood.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        [Required(ErrorMessage = "Fill empty input"), MaxLength(80)]
        public string Name { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }

    }
}
